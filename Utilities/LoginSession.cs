using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.DAL.Database;
using _3S_eShop.PatternDistinctive.Singleton;
using System.IO;
using System.Threading.Tasks;

namespace _3S_eShop.Utilities
{
    /// <summary>
    /// Lớp này dùng để quản lý phiên đăng nhập của người dùng.
    /// </summary>
    internal class LoginSession
    {
        private static string _file = ".session";

        /// <summary>
        /// Lấy thông tin người dùng từ tệp session và cập nhật thời gian đăng nhập nếu có thể.
        /// </summary>
        /// <returns>Instance DTO của người dùng</returns>
        public static UserDTO Get()
        {
            // Kiểm tra nếu tệp không tồn tại
            if (!File.Exists(_file))
            {
                return null;
            }

            // Đọc dữ liệu từ tệp
            SimpleFileStore sfs = new SimpleFileStore(_file, true);
            string email = sfs.Get("data");

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(email))
            {
                File.Delete(_file);
                return null;
            }

            // Giải mã dữ liệu
            email = Cipher3S.AESIV.Decrypt(email);

            // Lấy dữ liệu từ Redis
            string content = RedisHandler.ReadSignInSession(email);
            if (string.IsNullOrEmpty(content) ||
                !DeviceHandler.GetMotherboardSerialNumber().Equals(Cipher3S.AESIV.Decrypt(content)))
            {
                RedisHandler.RemoveSignInSession(email);
                File.Delete(_file);
                return null;
            }

            // Lấy thông tin tài
            UserBLL userBLL = new UserBLL(new UserDAO());
            UserDTO user = userBLL.GetMatchEmail(email);

            // Cập nhật thời gian đăng nhập nếu người dùng không null
            if (user != null)
            {
                // Hoạt động bất đồng bộ để không làm chậm quá trình đăng nhập
                Task.Run(() =>
                {
                    userBLL.UpdateLasteLoginDate(user);
                });
            }
            
            return user;
        }

        /// <summary>
        /// Tạo một phiên đăng nhập mới cho người dùng.
        /// </summary>
        /// <param name="email">Email của người dùng đăng nhập.</param>
        public static void Create(string email)
        {
            SimpleFileStore sfs = new SimpleFileStore(_file, true);
            sfs.Set("data", Cipher3S.AESIV.Encrypt(email));
            Logger.Instance.Log(LogLevel.Info, $"LOGIN - Đăng nhập với email {email}");
            RedisHandler.StoreSignInSession(
                email,
                Cipher3S.AESIV.Encrypt(DeviceHandler.GetMotherboardSerialNumber())
            );
        }

        /// <summary>
        /// Dọn dẹp session bằng cách quét dữ liệu trên máy và Redis
        /// </summary>
        public static void Clear()
        {
            SimpleFileStore sfs = new SimpleFileStore(_file, true);
            string email = sfs.Get("data");
            sfs = null;
            if (string.IsNullOrEmpty(email))
            {
                return;
            }
            RedisHandler.RemoveSignInSession(Cipher3S.AESIV.Decrypt(email));
            File.Delete(_file);
            email = null;
        }

    }
}

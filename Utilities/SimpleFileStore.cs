using System.Collections.Generic;
using System.IO;

namespace _3S_eShop
{
    internal class SimpleFileStore
    {
        private readonly string filePath;
        private bool encrypt;
        Dictionary<string, string> data;

        /// <summary>
        /// SimpleFileStore là một lớp dùng để lưu trữ dữ liệu dưới dạng key-value vào một tệp văn bản.
        /// Lớp có hỗ trợ ghi dữ liệu dưới dạng mã hóa AES-256 riêng được thiết lập của dự án 3S-eShop.
        /// </summary>
        /// <param name="filePath">Đường dẫn tới tệp lưu trữ dữ liệu.</param>
        /// <param name="encrypt">true => mã hóa dữ liệu; false => không mã hóa dữ liệu.</param>"
        public SimpleFileStore(string filePath, bool encrypt = false)
        {
            this.filePath = filePath;
            this.encrypt = encrypt;

            // Tạo tệp nếu chưa tồn tại
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            // Đọc dữ liệu từ tệp
            LoadDataFromFile();
        }

        /// <summary>
        /// Lưu cặp dữ liệu mới (ghi thay đổi vào tệp).
        /// </summary>
        /// <param name="key">Tên biến cần lưu.</param>
        /// <param name="value">Giá trị cần lưu.</param>
        /// <param name="append">Nếu true, ghi tiếp vào giá trị cũ; nếu false, ghi đè.</param>
        public void Set(string key, string value, bool append = false)
        {
            SoftSet(key, value, append);
            WriteDataToFile(data);
        }

        /// <summary>
        /// Lưu cặp dữ liệu mới (không ghi thay đổi vào tệp). Thích hợp với việc thêm tạm dữ liệu nhưng chưa lưu ngay (lưu nhiều dữ liệu một lúc), cần gọi hàm Save() để lưu dữ liệu vào tệp sau đó.
        /// </summary>
        /// <param name="key">Tên biến cần lưu.</param>
        /// <param name="value">Giá trị cần lưu.</param>
        /// <param name="append">Nếu true, ghi tiếp vào giá trị cũ; nếu false, ghi đè.</param>
        public void SoftSet(string key, string value, bool append = false)
        {
            // Ghi tiếp hoặc ghi đè dữ liệu
            if (append && data.ContainsKey(key))
            {
                data[key] += value; // Ghi tiếp
            }
            else
            {
                data[key] = value; // Ghi mới hoặc ghi đè
            }
        }

        /// <summary>
        /// Xuất dữ liệu.
        /// </summary>
        /// <returns>Dictionary<string,string>.</returns>
        public Dictionary<string, string> ExportData()
        {
            return data;
        }

        /// <summary>
        /// Lấy giá trị của một key cụ thể.
        /// </summary>
        /// <param name="key">Tên biến cần lấy giá trị.</param>
        /// <returns>Giá trị của key hoặc thông báo nếu key không tồn tại.</returns>
        public string Get(string key)
        {
            if (data.ContainsKey(key))
            {
                return data[key];
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Xóa một key cụ thể (lưu lại dữ liệu vào file).
        /// </summary>
        /// <param name="key">Tên biến cần xóa.</param>
        public void Remove(string key)
        {
            SoftDelete(key);
            WriteDataToFile(data);
        }

        /// <summary>
        /// Xóa một key cụ thể khỏi dữ liệu (không lưu vào file).
        /// </summary>
        /// <param name="key">Tên biến cần xóa.</param>
        public void SoftDelete(string key)
        {
            if (data.ContainsKey(key))
            {
                data.Remove(key);
            }
        }

        /// <summary>
        /// Lưu dữ liệu vào tệp.
        /// </summary>
        public void Save()
        {
            WriteDataToFile(data);
        }


        private void LoadDataFromFile()
        {
            data = new Dictionary<string, string>();
            var lines = File.ReadAllLines(filePath);

            if (encrypt)
            {
                foreach (var line in lines)
                {
                    var parts = Cipher3S.AESIV.Decrypt(line)?.Split(new[] { '=' }, 2);
                    if (parts == null) continue;
                    if (parts.Length == 2) data[parts[0]] = parts[1];
                }
            }
            else
            {
                foreach (var line in lines)
                {
                    var parts = line.Split(new[] { '=' }, 2);
                    if (parts.Length == 2) data[parts[0]] = parts[1];
                }
            }
        }
        private void WriteDataToFile(Dictionary<string, string> data)
        {
            using (var writer = new StreamWriter(filePath))
            {
                if (encrypt)
                {
                    foreach (var item in data)
                    {
                        writer.WriteLine(Cipher3S.AESIV.Encrypt($"{item.Key}={item.Value}"));
                    }
                }
                else
                {
                    foreach (var item in data)
                    {
                        writer.WriteLine($"{item.Key}={item.Value}");
                    }
                }
            }
        }

    }
}

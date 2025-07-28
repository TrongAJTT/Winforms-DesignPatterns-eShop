using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using System.Collections.Generic;
using System.IO;
using System;
using System.Threading.Tasks;
using System.Drawing;
using _3S_eShop.PatternDistinctive.Singleton;
using Cipher3S;

namespace _3S_eShop.DAL.CloudStore
{
    public class DriveHandler
    {
        private static string folderId = Environment.GetEnvironmentVariable("GDRIVE_FOLDER_ID");
        private static string credentialsPath = Environment.GetEnvironmentVariable("GDRIVE_CREDENTIALS_PATH");
        private static string applicationName = "3S eShop Drive Handler";

        /// <summary>
        /// Tải tệp được chỉ định lên Google Drive.
        /// </summary>
        /// <param name="fileToUpload">Đường dẫn của tệp cần tải lên.</param>
        /// <returns>Id của tệp</returns>
        public static async Task<string> UploadFilesToDrive(string fileToUpload)
        {
            try
            {
                var service = GetDriveService();

                var fileMetaData = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = Guid.NewGuid().ToString() + Path.GetExtension(fileToUpload),
                    Parents = new List<string> { folderId }
                };

                FilesResource.CreateMediaUpload request;
                using (var streamFile = new FileStream(fileToUpload, FileMode.Open))
                {
                    request = service.Files.Create(fileMetaData, streamFile, "");
                    request.Fields = "id";
                    await request.UploadAsync();
                }
                // From the response, extract meaningful information.
                var uploadedFile = request.ResponseBody;
                // Print this information to the console.
                Console.WriteLine($"File uploaded with ID: {uploadedFile.Id}");
                Logger.Instance.LogInfo($"DRIVE HANDLER - Tải tập tin lên thành công. Mã hành động: {AESIV.Encrypt(uploadedFile.Id)}");
                return uploadedFile.Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải file: {ex}");
                Logger.Instance.LogErrorException(ex, $"DRIVE HANDLER - Lỗi khi tải file");
                return null;
            }
        }

        /// <summary>
        /// Tải ảnh từ Image lên Google Drive, có lưu thông tin tag vào id.
        /// </summary>
        /// <param name="image">Biến chứa dữ liệu ảnh</param>
        /// <returns>Chuỗi có format: tag|id</returns>
        public static async Task<string> UploadImageToDriveWithinTag(Image image)
        {
            try
            {
                var service = GetDriveService();
                var fileMetaData = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = Guid.NewGuid().ToString() + ".jpg",
                    Parents = new List<string> { folderId }
                };
                FilesResource.CreateMediaUpload request;
                using (var stream = new MemoryStream())
                {
                    image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    stream.Position = 0;
                    request = service.Files.Create(fileMetaData, stream, "image/jpeg");
                    request.Fields = "id";
                    await request.UploadAsync();
                }
                // From the response, extract meaningful information.
                var uploadedFile = request.ResponseBody;
                // Print this information to the console.
                Console.WriteLine($"Image tag {image.Tag} uploaded with ID: {uploadedFile.Id}");
                Logger.Instance.LogInfo($"DRIVE HANDLER - Tải ảnh lên thành công. Mã hành động: {AESIV.Encrypt(uploadedFile.Id)}");
                return image.Tag + "|" + uploadedFile.Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải file: {ex}");
                Logger.Instance.LogErrorException(ex, $"DRIVE HANDLER - Lỗi khi tải file");
                return null;
            }
        }

        /// <summary>
        /// Tải ảnh từ MemoryStream lên Google Drive.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static async Task<string> UploadImageFromStreamMemoryToDrive(MemoryStream stream)
        {
            try
            {
                var service = GetDriveService();

                var fileMetaData = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = Guid.NewGuid().ToString() + "",
                    Parents = new List<string> { folderId }
                };

                FilesResource.CreateMediaUpload request;
                request = service.Files.Create(fileMetaData, stream, "");
                request.Fields = "id";
                await request.UploadAsync();

                // From the response, extract meaningful information.
                var uploadedFile = request.ResponseBody;
                // Print this information to the console.
                Console.WriteLine($"File uploaded with ID: {uploadedFile.Id}");
                Logger.Instance.LogInfo($"DRIVE HANDLER - Tải tập tin lên thành công. Mã hành động: {AESIV.Encrypt(uploadedFile.Id)}");
                return uploadedFile.Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải file: {ex}");
                Logger.Instance.LogErrorException(ex, $"DRIVE HANDLER - Lỗi khi tải file");
                return null;
            }
        }

        /// <summary>
        /// Tải file từ Google Drive về dưới dạng MemoryStream.
        /// </summary>
        /// <param name="fileId">Id của file cần tải về trên Drive</param>
        /// <returns></returns>
        public static async Task<MemoryStream> DownloadFilesFromDrive(string fileId)
        {
            var service = GetDriveService();
            try
            {
                // Tạo request để download file.
                var request = service.Files.Get(fileId);
                // Tải file về dưới dạng MemoryStream.
                var stream = new MemoryStream();
                await request.DownloadAsync(stream);
                stream.Position = 0;
                // Quan trọng: Đặt lại vị trí stream về đầu để đọc dữ liệu.
                return stream;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải file: {ex}");
                Logger.Instance.LogErrorException(ex, $"DRIVE HANDLER - Lỗi khi tải file");
                throw ex;
            }
        }

        // Xóa file khỏi Google Drive (bất đồng bộ, không cần chờ).
        public static void DeleteFileFromDrive(string fileId)
        {
            Task.Run(() =>
            {
                var service = GetDriveService();
                try
                {
                    // Tạo request để xóa file.
                    var request = service.Files.Delete(fileId);
                    // Thực hiện xóa file.
                    request.Execute();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi xóa file: {ex}");
                    Logger.Instance.LogErrorException(ex, $"DRIVE HANDLER - Lỗi khi xóa file");
                }
            });
        }

        // Tạo service để thao tác với Google Drive.
        private static DriveService GetDriveService()
        {
            DriveService service;
            using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
            {
                GoogleCredential credential = GoogleCredential.FromStream(stream).CreateScoped(new[]
                {
                    DriveService.ScopeConstants.DriveFile
                });
                service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = applicationName
                });
            }
            return service;
        }

    }
}

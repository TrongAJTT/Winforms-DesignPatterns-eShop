using System.Management;
using System;
using _3S_eShop.PatternDistinctive.Singleton;

namespace _3S_eShop.Utilities
{
    /// <summary>
    /// Một lớp dùng để xử lý các thông tin về phần cứng thiết bị.
    /// </summary>
    internal class DeviceHandler
    {
        /// <summary>
        /// Truy vấn mã số serial của bo mạch chủ.
        /// </summary>
        /// <returns>Chuỗi ký tự đại diện cho số serial của bo mạch chủ</returns>
        public static string GetMotherboardSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
                ManagementObjectCollection objects = searcher.Get();
                foreach (ManagementObject obj in objects)
                {
                    return obj["SerialNumber"].ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting motherboard serial number: " + ex.Message);
                Logger.Instance.LogErrorException(ex, "Lỗi khi tải số serial của bo mạch chủ");
            }
            return null;
        }
    }
}

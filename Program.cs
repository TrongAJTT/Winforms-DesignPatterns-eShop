using _3S_eShop.BLL.DTOs;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.PatternDistinctive.Singleton;
using _3S_eShop.Resources;
using _3S_eShop.Utilities;
using DotNetEnv;
using System;
using System.IO;
using System.Windows.Forms;

namespace _3S_eShop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EntryPoint();
        }

        private static void CheckFile()
        {
            if (!File.Exists(".recent"))
            {
                File.Create(".recent").Close();
            }
            if (!File.Exists(".cart"))
            {
                File.Create(".cart").Close();
            }
            if (!Directory.Exists("log"))
            {
                Directory.CreateDirectory("log");
            }
        }

        private static void CheckConnection()
        {
            if (!NetWorking.IsNetworkAvailable())
            {
                Logger.Instance.LogError("Không tìm thấy kết nối mạng hoặc kết nối bị gián đoạn -> Buộc dừng chương trình.");
                MessageBox.Show("Không có kết nối mạng!\nBuộc dừng chương trình", "Báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MySystem.Terminate();
            }
        }

        private static void LogEntry()
        {
            Logger.Instance.LogInfo("KHỞI CHẠY PHIÊN MỚI -----");
        }

        static void EntryPoint()
        {
            // Ghi log phiên mới
            LogEntry();
            // Kiểm tra kết nối mạng
            CheckConnection();
            // Kiểm tra tập tin
            CheckFile();
            // Tải biến môi trường
            Env.Load("secret_data/.env");
            // Tạo instance của MainForm
            MainForm mainForm = new MainForm();
            // Thiết lập MainForm cho MySystem
            MySystem.SetMainForm(mainForm);
            // Khởi động ứng dụng
             Application.Run(mainForm);
            //Application.Run(new TestForm());
        }
    }
}
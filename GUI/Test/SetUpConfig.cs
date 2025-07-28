using _3S_eShop.CustomControls;
using _3S_eShop.Utilities;
using DotNetEnv;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _3S_eShop.GUI.Test
{
    public partial class SetUpConfig : Form
    {
        private static Color pass = Color.Lime, deactiveClr = Color.Red;

        public SetUpConfig()
        {
            InitializeComponent();
            GetTestResult();
            ToolTipHelper.AppendToControl(btnSecret, "Kéo thả thư mục chứa tệp tin bí mật vào đây");
        }

        private void btnDb_Click(object sender, EventArgs e)
        {
            if (btnSecret.BackColor != pass)
            {
                ToastBox alertBox = new ToastBox(4);
                alertBox.ShowToast("Vui lòng chọn thư mục chứa tệp tin bí mật trước khi thiết lập cơ sở dữ liệu", ToastBox.enmType.Warning);
                return;
            }
            new DatabaseConfig().ShowDialog();
            btnDb.BackColor = new DatabaseConfig().CheckConnect() ? pass : deactiveClr;
        }   

        private void btnStorage_Click(object sender, EventArgs e)
        {
            if (btnSecret.BackColor != pass)
            {
                ToastBox alertBox = new ToastBox(4);
                alertBox.ShowToast("Vui lòng chọn thư mục chứa tệp tin bí mật trước khi thiết lập máy chủ cache", ToastBox.enmType.Warning);
                return;
            }
            new RedisConfig().ShowDialog();
            btnRedis.BackColor = new RedisConfig().CheckConnect() ? pass : deactiveClr;
        }

        private void GetTestResult()
        {
            btnDb.BackColor = new DatabaseConfig().CheckConnect() ? pass : deactiveClr;
            btnRedis.BackColor = new RedisConfig().CheckConnect() ? pass : deactiveClr;
            btnSecret.BackColor = new SimpleFileStore(".setup", false).Get("secret_folder") != "" ?
                pass : deactiveClr;
        }

        private void btnSecret_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                ProcessSecretFolder(path);
            }
        }

        private void btnSecret_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            ProcessSecretFolder(path);
        }

        private void ProcessSecretFolder(string path)
        {
            string result = EditSecretFolder(path);
            if (result != "")
            {
                btnSecret.BackColor = deactiveClr;
                MessageBox.Show(result);
            }
            else
            {
                btnSecret.BackColor = pass;
            }
        }

        private string EditSecretFolder(string path)
        {
            // Kiểm tra tệp tin
            if (!File.Exists(path + "/.env")) return "Thiếu tệp .env";
            if (!File.Exists(path + "/GDriveCredentials.json")) return "Thiếu tệp GDriveCredentials.json";
            if (!File.Exists(path + "/GOathCredentials.json")) return "Thiếu tệp GOathCredentials.json";

            // Lưu đường dẫn
            path += "/.env";
            SimpleFileStore sfs = new SimpleFileStore(".setup", true);
            sfs.Set("secret_folder", path);

            // Tải biến môi trường
            Env.Load(path);

            return "";
        }

        private void btnSecret_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // Khởi động lại ứng dụng
            string exePath = Process.GetCurrentProcess().MainModule.FileName;
            Process.Start(exePath);
            Environment.Exit(0);
        }

        public static bool CheckConnect()
        {
            SetUpConfig cc = new SetUpConfig();
            return cc.btnDb.BackColor == pass && cc.btnRedis.BackColor == pass;
        }

    }
}

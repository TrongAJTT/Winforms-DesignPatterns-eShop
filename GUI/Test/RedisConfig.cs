using _3S_eShop.Connect;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.GUI.Test
{
    public partial class RedisConfig : Form
    {
        private SimpleFileStore sfs = new SimpleFileStore(".connect", true);
        private String keyHost = "redis_host";
        private String keyPort = "redis_port";
        private String keyUser= "redis_user";
        private String keyPass = "redis_pass";

        public RedisConfig()
        {
            InitializeComponent();
            InitializeUI();
        }

        // Khởi tạo giao diện
        private void InitializeUI()
        {
            txtHost.Texts = sfs.Get(keyHost);
            txtPort.Texts = sfs.Get(keyPort);
            txtUname.Texts = sfs.Get(keyUser);
            txtPass.Texts = sfs.Get(keyPass);
        }

        // Sự kiện khi nhấn nút thiết lập cho dữ liệu đám mây
        private void btnCloud_Click(object sender, EventArgs e)
        {
            txtHost.Texts = Environment.GetEnvironmentVariable("REDIS_HOST");
            txtPort.Texts = Environment.GetEnvironmentVariable("REDIS_PORT");
            txtUname.Texts = Environment.GetEnvironmentVariable("REDIS_USER");
            txtPass.Texts = Environment.GetEnvironmentVariable("REDIS_PASS");
            btnConnect.PerformClick();
        }

        // Sự kiện khi nhấn nút kết nối
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string s = Redis.TestConnection(txtHost.Texts, txtPort.Texts, txtUname.Texts, txtPass.Texts);
            if (s == null)
            {
                lblTrangThai.Text = "Kết nối đến server thành công";
                lblTrangThai.ForeColor = Color.LightGreen;
            }
            else
            {
                lblTrangThai.Text = "Kết nối thất bại";
                txtFail.Texts = s;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        // Hàm lưu dữ liệu
        private void SaveData()
        {
            sfs.SoftSet(keyHost, txtHost.Texts);
            sfs.SoftSet(keyPort, txtPort.Texts);
            sfs.SoftSet(keyUser, txtUname.Texts);
            sfs.SoftSet(keyPass, txtPass.Texts);
            sfs.Save();
        }

        // Sự kiện khi nhấn nút quay về
        private void btnBack_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }

        // Kiểm tra kết nối
        public bool CheckConnect()
        {
            return Redis.TestConnection(txtHost.Texts, txtPort.Texts, txtUname.Texts, txtPass.Texts) == null;
        }
    }
}

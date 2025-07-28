using _3S_eShop.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop
{
    public partial class DatabaseConfig : Form
    {
        private SimpleFileStore sfs = new SimpleFileStore(".connect", true);
        private String keyType = "db_type";
        private String keyHost = "db_host";
        private String keyPort = "db_port";
        private String keyName = "db_name";
        private String keyPass = "db_pass";
        private String keyUname = "db_uname";
        private String keyConn = "db_conn";
        private String connStr = "";

        public DatabaseConfig()
        {
            InitializeComponent();
            InitializeUI();
            connStr = CreateConnectionString();
        }

        // Khởi tạo giao diện
        private void InitializeUI()
        {
            String dbType = sfs.Get(keyType);
            if (string.IsNullOrEmpty(dbType))
            {
                rdoMySql.Checked = true;
                txtHost.Texts = "localhost";
                txtPort.Texts = "3306";
                txtDatabase.Texts = "3S_eShopDb";
                txtUname.Texts = "root";
                txtPass.Texts = "root";
            }
            else
            {
                if (dbType.Equals("mysql")) rdoMySql.Checked = true;
                else rdoSqlServer.Checked = true;
                txtHost.Texts = sfs.Get(keyHost);
                txtPort.Texts = sfs.Get(keyPort);
                txtDatabase.Texts = sfs.Get(keyName);
                txtUname.Texts = sfs.Get(keyUname);
                txtPass.Texts = sfs.Get(keyPass);
            }
        }

        // Sự kiện khi nhấn nút kết nối
        private void btnConnect_Click(object sender, EventArgs e)
        {
            String s = DataProvider.TryConnecting(connStr, GetDbType());
            if (s == null)
            {
                lblTrangThai.Text = "Kết nối đến server thành công";
                lblTrangThai.ForeColor = Color.LightGreen;
                DataProvider.Instance.SetConnectionString();
            }
            else
            {
                lblTrangThai.Text = "Kết nối thất bại";
                txtFail.Texts = s;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        // Đổi cấu hình sang đám mây
        private void btnCloud_Click(object sender, EventArgs e)
        {
            rdoMySql.Checked = true;
            txtHost.Texts = Environment.GetEnvironmentVariable("DB_HOST");
            txtPort.Texts = Environment.GetEnvironmentVariable("DB_PORT");
            txtDatabase.Texts = Environment.GetEnvironmentVariable("DB_NAME");
            txtUname.Texts = Environment.GetEnvironmentVariable("DB_USER");
            txtPass.Texts = Environment.GetEnvironmentVariable("DB_PASS");
            btnConnect.PerformClick();
        }

        // Kiểm tra kết nối
        public bool CheckConnect()
        {
            return DataProvider.TryConnecting(connStr, GetDbType()) == null;
        }

        // Tạo chuỗi kết nối
        private String CreateConnectionString()
        {
            if (rdoMySql.Checked)
            {
                return $"Server={txtHost.Texts};Port={txtPort.Texts};Database={txtDatabase.Texts};Uid={txtUname.Texts};Pwd={txtPass.Texts};";
            }
            else
            {
                return $"Server={txtHost.Texts},{txtPort.Texts};Database={txtDatabase.Texts};User Id={txtUname.Texts};Password={txtPass.Texts};";
            }
        }

        // Lấy loại cơ sở dữ liệu
        private string GetDbType()
        {
            return rdoMySql.Checked ? MySystem.DB_TYPE_MYSQL : MySystem.DB_TYPE_SQLSERVER;
        }

        // Lưu dữ liệu
        private void SaveData()
        {
            sfs.SoftSet(keyType, GetDbType());
            sfs.SoftSet(keyHost, txtHost.Texts);
            sfs.SoftSet(keyPort, txtPort.Texts);
            sfs.SoftSet(keyName, txtDatabase.Texts);
            sfs.SoftSet(keyUname, txtUname.Texts);
            sfs.SoftSet(keyPass, txtPass.Texts);
            sfs.SoftSet(keyConn, CreateConnectionString());
            sfs.Save();
        }

        private void rdoMySql_CheckedChanged(object sender, EventArgs e)
        {
            txtPort.Texts = rdoMySql.Checked ? "3306" : "1433";
            connStr = CreateConnectionString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connStr = CreateConnectionString();
        }

        private void txtHost__TextChanged(object sender, EventArgs e)
        {
            connStr = CreateConnectionString();
        }

        private void txtPort__TextChanged(object sender, EventArgs e)
        {
            connStr = CreateConnectionString();
        }

        private void txtDatabase__TextChanged(object sender, EventArgs e)
        {
            connStr = CreateConnectionString();
        }

        private void txtUname__TextChanged(object sender, EventArgs e)
        {
            connStr = CreateConnectionString();
        }

        private void txtPass__TextChanged(object sender, EventArgs e)
        {
            connStr = CreateConnectionString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }
    }
}

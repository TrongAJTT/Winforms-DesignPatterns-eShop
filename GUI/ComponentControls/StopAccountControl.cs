using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.BLL;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.Utilities;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class StopAccountControl: UserControl
    {
        public StopAccountControl()
        {
            InitializeComponent();
        }

        private void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            btnStopMyAccount.Enabled = chkAgree.Checked;
        }

        private void btnStopMyAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đây là cơ hội cuối cùng để bạn nghĩ lại.\n" +
                "Bạn có chắc chắn muốn dừng tài khoản của mình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Tạo đối tượng truy cập dữ liệu
                var userBll = new UserBLL(new UserDAO());
                // Cập nhật trạng thái tài khoản trong nền
                Task.Run(() => userBll.StopAccount(MainForm.User.Id, txtReason.Text));
                // Đăng xuất người dùng
                LoginSession.Clear();
                // Thông báo
                MessageBox.Show("Bạn đã được đăng xuất khỏi tài khoản.\n" +
                    "Chương trình sẽ tự khởi động lại!");
                // Khởi động lại ứng dụng
                MySystem.Restart();
            }
        }
    }
}

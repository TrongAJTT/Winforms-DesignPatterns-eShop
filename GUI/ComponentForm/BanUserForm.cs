using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class BanUserForm: Form
    {
        private string name;
        private string email;
        private long id;
        public BanUserForm()
        {
            InitializeComponent();
        }

        public BanUserForm(string name, string email, long id)
        {
            InitializeComponent();
            this.name = name;
            this.email = email;
            lblTitle.Text = $"CẤM NGƯỜI DÙNG {name.ToUpper()}";
            lblEmail.Text = $"Email: {email}";
            this.id = id;
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            // Logic ban user
            UserFacade userFacade = new UserFacade(new UserDAO());
            userFacade.UpdateActive(id, false, txtReason.Texts);
            MessageBox.Show("Cấm người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Đóng form
            this.Close();
        }
    }
}

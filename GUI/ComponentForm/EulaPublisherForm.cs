using _3S_eShop.CustomControls;
using _3S_eShop.DAL.Database;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class EulaPublisherForm: Form
    {
        public EulaPublisherForm()
        {
            InitializeComponent();
            GetData();
            contentEula.TextChanged += (s, e) =>
            {
                btnUpdate.Enabled = contentEula.Text.Length > 0;
            };
        }

        private async void GetData()
        {
            List<Task<string>> getDataTask = new List<Task<string>>();
            getDataTask.Add(Task.Run(() => RedisHandler.GetPolicyContent()));
            getDataTask.Add(Task.Run(() => RedisHandler.GetPolicyDate()));
            string[] result = await Task.WhenAll(getDataTask);
            contentEula.Text = result[0];
            dateEula.Text = result[1];
        }

        private async void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Chắc chắn cập nhật điều khoản dịch vụ?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bool updateResult = await UpdatePolicyAsync();
                if (updateResult)
                {
                    btnUpdate.Enabled = false;
                    dateEula.Text = DateTime.Now.ToString();
                }
            }
        }

        private async Task<bool> UpdatePolicyAsync()
        {
            this.ControlBox = false;
            loadingControl.Visible = true;
            loadingControl.Message = "Đang xác minh người dùng...";

            if (MainForm.Role.Id != 1)
            {
                loadingControl.Visible = false;
                this.ControlBox = true;
                MySystem.ShowToastMessageAtTopRight("Xác minh thất bại. Bạn không đủ quyền truy cập vào chức năng này", ToastBox.enmType.Error);
                return false;
            }

            int random = new Random().Next(1, 5);
            await Task.Delay(random * 1000);
            
            loadingControl.Message = "Đang lấy thông tin điều khoản dịch vụ...";

            random = new Random().Next(1, 5);
            await Task.Delay(random * 1000);

            loadingControl.Message = "Đang cập nhật điều khoản dịch vụ...";

            RedisHandler.UpdatePolicy(contentEula.Text);

            random = new Random().Next(1, 4);
            await Task.Delay(random * 1000);

            MySystem.ShowToastMessageAtTopRight("Cập nhật điều khoản dịch vụ thành công");
            this.ControlBox = true;
            loadingControl.Visible = false;

            return true;
        }
    }
}

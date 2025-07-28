using System;
using System.Windows.Forms;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.BLL;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.Utilities;

namespace _3S_eShop.GUI.MainControls.Manager
{
    public partial class UserAddressManagerControl: UserControl
    {
        public UserAddressManagerControl()
        {
            InitializeComponent();
        }

        private void LoadAddress()
        {
            EmbedControl.SetLoadingForThisControl(this, "Đang tải dữ liệu địa chỉ");
            var dao = new UserAddressDAO();
            var bll = new UserAddressBLL(dao);
            var addresses = bll.GetAddressOfUser(MainForm.User.Id);

            flowAddress.Controls.Clear();
            if (addresses != null && addresses.Count > 0)
            {
                foreach ( var address in addresses )
                {
                    var userAddressControl = new UserAddressControl(address);
                    userAddressControl.Width = flowAddress.Width - 30;
                    userAddressControl.Margin = new Padding(5);
                    userAddressControl.OnRequestEdit += (s, e) =>
                    {
                        // Xử lý sự kiện yêu cầu chỉnh sửa địa chỉ
                        var editForm = new AddressEditorForm(address);
                        editForm.ShowDialog();
                        if (editForm.IsComplete)
                        {
                            LoadAddress();
                        }
                    };
                    userAddressControl.OnRequestDelete += (s, e) =>
                    {
                        // Xử lý sự kiện yêu cầu xóa địa chỉ
                        var result = MessageBox.Show("Bạn có chắc chắn muốn xóa địa chỉ này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            EmbedControl.SetLoadingForThisControl(this, "Đang cập nhật dữ liệu");
                            dao.Delete(address);
                            MySystem.ShowToastMessageAtTopRight("Đã xóa địa chỉ thành công");
                            LoadAddress();
                        }
                    };
                    userAddressControl.OnRequestSetDefault += (s, e) =>
                    {
                        // Xử lý sự kiện yêu cầu đặt địa chỉ mặc định
                        var result = MessageBox.Show("Bạn có chắc chắn muốn đặt địa chỉ này làm mặc định?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            EmbedControl.SetLoadingForThisControl(this, "Đang cập nhật dữ liệu");
                            bll.SetDefaultAddressFor(address.Id);
                            MySystem.ShowToastMessageAtTopRight("Cập nhật địa chỉ mặc định hoàn tất");
                            LoadAddress();
                        }
                    };
                    flowAddress.Controls.Add(userAddressControl);
                }
            }
            else
            {
                // Không có địa chỉ nào
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources.no_data_found;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new System.Drawing.Size(flowAddress.Width-20, 400);
                flowAddress.Controls.Add(pictureBox);
            }

            EmbedControl.RemoveLoadingForThisControl(this);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddressEditorForm addressEditorForm = new AddressEditorForm();
            addressEditorForm.ShowDialog();
            if (addressEditorForm.IsComplete)
            {
                LoadAddress();
            }
        }

        private void UserAddressManagerControl_Load(object sender, EventArgs e)
        {
            LoadAddress();
        }
    }
}

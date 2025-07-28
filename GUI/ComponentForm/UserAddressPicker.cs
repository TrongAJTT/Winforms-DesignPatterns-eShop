using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.GUI.MainControls;
using System;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class UserAddressPicker: Form
    {
        private UserAddressDTO pickedAddress;

        public UserAddressPicker()
        {
            InitializeComponent();
        }

        public UserAddressDTO PickedAddress { get => pickedAddress; }

        private void LoadAddress()
        {
            EmbedControl.SetLoadingForThisControl(this, "Đang tải dữ liệu địa chỉ");
            var dao = new UserAddressDAO();
            var bll = new UserAddressBLL(dao);
            var addresses = bll.GetAddressOfUser(MainForm.User.Id);

            flowAddress.Controls.Clear();
            if (addresses != null && addresses.Count > 0)
            {
                foreach (var address in addresses)
                {
                    var userAddressControl = new UserAddressControl(address);
                    userAddressControl.Width = flowAddress.Width - 30;
                    userAddressControl.Margin = new Padding(5);
                    userAddressControl.EnableContextMenu = false;
                    userAddressControl.EnablePickButton = true;

                    userAddressControl.OnRequestPick += (s, e) =>
                    {
                        pickedAddress = address;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
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
                pictureBox.Size = new System.Drawing.Size(flowAddress.Width - 20, 400);
                flowAddress.Controls.Add(pictureBox);
            }

            EmbedControl.RemoveLoadingForThisControl(this);

        }

        private void UserAddressPicker_Load(object sender, EventArgs e)
        {
            LoadAddress();
        }
    }
}

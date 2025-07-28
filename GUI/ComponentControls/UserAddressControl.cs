using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using _3S_eShop.BLL.DTOs;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class UserAddressControl: UserControl
    {
        private static string prefix = "      ";
        private UserAddressDTO _value;
        private bool allowEdit = true, contextMenu = true;

        public EventHandler OnRequestEdit, OnRequestDelete, OnRequestSetDefault, OnRequestPick;

        public UserAddressControl()
        {
            InitializeComponent();
        }

        public UserAddressControl(UserAddressDTO userAddress) : this()
        {
            _value = userAddress;
            LoadData();
        }

        [Category("Advanced Settings")]
        [Description("Màu nền của container")]
        public Color ContainerBackColor
        {
            get => containerPanel.BackColor;
            set => containerPanel.BackColor = value;
        }

        [Category("Advanced Settings")]
        [Description("Màu viền của container")]
        public Color ContainerBorderColor
        {
            get => containerPanel.BorderColor;
            set => containerPanel.BorderColor = value;
        }

        /// <summary>
        /// Trả về hoặc thiết lập thông tin địa chỉ giao hàng
        /// </summary>
        [Category("Advanced Settings")]
        [Description("Thông tin giao hàng")]
        public UserAddressDTO Value
        {
            get => _value;
            set
            {
                _value = value;
                LoadData();
            }
        }

        /// <summary>
        /// Cho phép chỉnh sửa địa chỉ hay không
        /// </summary>
        [Category("Advanced Settings")]
        [Description("Cho phép chỉnh sửa địa chỉ hay không")]
        public bool AllowEdit
        {
            get => allowEdit;
            set
            {
                allowEdit = value;
                this.ContextMenuStrip = value ? cmsAddress : null;
            }
        }

        /// <summary>
        /// Cho phép hiện menu chuột phải hay không
        /// </summary>
        public bool EnableContextMenu
        {
            get => contextMenu;
            set
            {
                contextMenu = value;
                if (value)
                {
                    this.ContextMenuStrip = cmsAddress;
                }
                else
                {
                    this.ContextMenuStrip = null;
                }
            }
        }

        /// <summary>
        /// Cho phép hiện nút chọn địa chỉ hay không
        /// </summary>
        public bool EnablePickButton
        {
            get => btnPick.Visible;
            set => btnPick.Visible = value;
        }

        private void LoadData()
        {
            if (_value != null)
            {
                // Tải dữ liệu lên giao diện
                lblRecipient.Text = $"{prefix}{_value.RecipientName}";
                lblPhone.Text = $"{prefix}{_value.RecipientPhone}" ;
                lblAdminArea.Text = $"{prefix}{_value.AdministrativeArea}";
                lblStreet.Text = $"{prefix}{_value.StreetAddress}";
                lblDefault.Visible = _value.IsDefault;
                // Thiết lập Context menu
                if (_value.IsDefault)
                {
                    tsmiDefault.Enabled = false;
                    tsmiDefault.Text = "Địa chỉ này hiện đang là mặc định";
                    tsmiDelete.Enabled = false;
                    tsmiDelete.Text = "Không thể xóa địa chỉ mặc định";
                }
                else
                {
                    tsmiDefault.Enabled = true;
                    tsmiDefault.Text = "Đặt địa chỉ này làm mặc định";
                    tsmiDelete.Enabled = true;
                    tsmiDelete.Text = "Xóa địa chỉ này";
                }
            }
        }

        private void tsmiEdit_Click(object sender, System.EventArgs e)
        {
            this.OnRequestEdit?.Invoke(this, EventArgs.Empty);
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            this.OnRequestPick?.Invoke(this, EventArgs.Empty);
        }

        private void tsmiDefault_Click(object sender, EventArgs e)
        {
            this.OnRequestSetDefault?.Invoke(this, EventArgs.Empty);
        }

        private void tsmiDelete_Click(object sender, System.EventArgs e)
        {
            this.OnRequestDelete?.Invoke(this, EventArgs.Empty);
        }
    }
}

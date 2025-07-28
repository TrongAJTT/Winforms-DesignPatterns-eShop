using _3S_eShop.Utilities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    /// <summary>
    /// UserControl phân trang
    /// </summary>
    public partial class PaginationSelector : UserControl
    {
        private long currentPage, maxPage, maxSize;
        public EventHandler OnPageSizeChanged, OnPageChanged;

        public PaginationSelector()
        {
            InitializeComponent();
            InitializeEvents();
            InitializeTooltip();
            PageSize = 20;
            MaxSize = 30;
        }

        private void InitializeEvents()
        {
            txtPageSize.TextBox.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    int newPageSize = Convert.ToInt32(txtPageSize.Texts);
                    // Thay đổi kích thước trang, gọi Event Callback và truyền vào giá trị mới  
                    if (newPageSize >= 1)
                    {
                        PageSize = newPageSize;
                        OnPageSizeChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
                // Kiểm tra xem ký tự vừa nhập có phải là số hoặc ký tự điều khiển  
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    // Nếu không phải số và không phải ký tự điều khiển, ngăn không cho ký tự đó được nhập vào TextBox  
                    e.Handled = true;
                }
            };
            txtPageCurrent.TextBox.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    CurrentPage = Convert.ToInt32(txtPageCurrent.Texts);
                }
                // Kiểm tra xem ký tự vừa nhập có phải là số hoặc ký tự điều khiển  
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    // Nếu không phải số và không phải ký tự điều khiển, ngăn không cho ký tự đó được nhập vào TextBox  
                    e.Handled = true;
                }
            };
        }

        private void InitializeTooltip()
        {
            ToolTipHelper.AppendToControl(btnFirst, "Trang đầu");
            ToolTipHelper.AppendToControl(btnPrev, "Trang trước");
            ToolTipHelper.AppendToControl(btnNext, "Trang sau");
            ToolTipHelper.AppendToControl(btnFinal, "Trang cuối");
            ToolTipHelper.AppendToControl(txtPageSize, "Số bản ghi trên mỗi trang");
        }

        /// <summary>
        /// Số bản ghi trên mỗi trang.
        /// </summary>
        [Category("Advanced Configuration")]
        [Description("Màu chủ đạo.")]
        public Color PrimaryColor
        {
            get => backSize.BackColor;
            set => backSize.BackColor = backSize.BorderColor
                = btnFirst.BackColor = btnFirst.BorderColor
                = btnPrev.BackColor = btnPrev.BorderColor
                = btnNext.BackColor = btnNext.BorderColor
                = btnFinal.BackColor = btnFinal.BorderColor
                = txtPageMax.BackColor = txtPageMax.BorderColor 
                = txtPageSize.ForeColor = txtPageSize.BorderColor
                = txtPageCurrent.ForeColor = txtPageCurrent.BorderColor = value;
        }

        /// <summary>
        /// Số dòng trên mỗi trang.
        /// </summary>
        [Category("Advanced Configuration")]
        [Description("Số bản ghi trên mỗi trang.")]
        public long PageSize
        {
            get => Convert.ToInt64(txtPageSize.Texts);
            set
            {
                if (value > 0)
                {
                    txtPageSize.Texts = value.ToString();
                    MaxPage = (int)Math.Ceiling((double)maxSize / value);
                }
            }
        }

        /// <summary>
        /// Trang hiện tại.
        /// </summary>
        [Category("Advanced Configuration")]
        [Description("Trang hiện tại.")]
        public long CurrentPage
        {
            get => currentPage;
            set
            {
                if (value != currentPage)
                {
                    if (value < 1)
                    {
                        value = 1;
                    }
                    else if (value > maxPage)
                    {
                        value = MaxPage;
                    }
                    currentPage = value;
                    txtPageCurrent.Texts = currentPage.ToString();
                    OnPageChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        ///số lượng trang, khi chỉnh thì trang hiện tại tự về 1.
        /// </summary>
        [Category("Advanced Configuration")]
        [Description("Kích cỡ trang tối đa, khi chỉnh thì trang hiện tại tự về 1.")]
        public long MaxPage
        {
            get => maxPage;
            private set
            {
                maxPage = value;
                CurrentPage = 1;
                txtPageMax.Text = $"/ {value}";
            }
        }

        /// <summary>
        /// số lượng dòng, khi chỉnh thì trang hiện tại tự về 1.
        /// </summary>
        [Category("Advanced Configuration")]
        [Description("Kích thước tối đa, khi chỉnh thì trang hiện tại tự về 1 và sửa lại MaxPage.")]
        public long MaxSize
        {
            get => maxSize;
            set
            {
                if (value >= 0)
                {
                    maxSize = value;
                    MaxPage = (int)Math.Ceiling((double)maxSize / PageSize);
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            CurrentPage = MaxPage;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CurrentPage--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;
        }
    }
}

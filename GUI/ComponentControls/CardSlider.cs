using _3S_eShop.CustomComponents;
using _3S_eShop.Utilities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.CustomControls
{
    public partial class CardSlider : UserControl
    {
        private int _maxItem = 10, _spacing = 15, _outerSpace = 15, _titleSpacing = 3, noItem = 10;
        private int childMinX = 0;
        private Padding _containerPadding = new Padding(15);
        private Size _itemSize = new Size(202, 376);
        private bool isLongClick = false, isLeftClick = false;
        private Timer longClickTimer;

        private static int TIMER_INTERVAL = 50, SLIDE_RANGE = 35;

        public EventHandler OnViewAllClicked;

        public CardSlider()
        {
            InitializeComponent();
            noItem = flowContent.Controls.Count;
            Redraw();
            UpdateChildMinX();
            btnAction.Size = new Size(150, 40);
        }

        // Thuộc tính
        [Category("Advanced Settings")]
        [Description("Hình ảnh bên trái tiêu đề, kích thước khuyến nghị là 32*32px đến 40*40px")]
        public Image LeadingImage { get => lblTitle.Image; set => lblTitle.Image = value; }

        [Category("Advanced Settings")]
        [Description("Khoảng trống bên trái của tiêu đề để chừa chỗ cho Leading Image")]
        public int TitleSpacing
        { 
            get => _titleSpacing; 
            set
            {
                _titleSpacing = value < 0 ? 0 : value;
                lblTitle.Text = new string(' ', value) + lblTitle.Text.Trim();
            }
        }

        [Category("Advanced Settings")]
        [Description("Hình ảnh nút điều hướng trái")]
        public Image NavLeftImage { get => btnLeft.Image; set => btnLeft.Image = value; }

        [Category("Advanced Settings")]
        [Description("Hình ảnh nút điều hướng phải")]
        public Image NavRightImage { get => btnRight.Image; set => btnRight.Image = value; }

        [Category("Advanced Settings")]
        [Description("Chỉ số bo góc của hai nút điều hướng")]
        public int NavButtonRadius
        { 
            get => btnRight.BorderRadius; 
            set => btnRight.BorderRadius = btnLeft.BorderRadius = value; 
        }

        [Category("Advanced Settings")]
        [Description("Màu của hai nút điều hướng")]
        public Color NavButtonColor
        { 
            get => btnLeft.BackColor;
            set => btnRight.BackColor = btnLeft.BackColor = value;
        }

        [Category("Advanced Settings")]
        [Description("Kích thước của hai nút điều hướng")]
        public int NavButtonSize
        {
            get => btnRight.Width;
            set
            {
                btnRight.Size = btnLeft.Size = new Size(value, value);
                int newY = mainContainer.Height / 2 + mainContainer.Location.Y - (value/2);
                btnLeft.Location = new Point(0, newY);
                btnRight.Location = new Point(this.Width - value, newY);
            }
        }

        [Category("Advanced Settings")]
        [Description("Tiêu đề của khung card slider")]
        public string Title 
        { 
            get => lblTitle.Text.Trim(); 
            set => lblTitle.Text = new string(' ', _titleSpacing) + value;
        }

        [Category("Advanced Settings")]
        [Description("Khoảng trống bên trái và bên phải")]
        public int OuterSpace
        {
            get => _outerSpace; 
            set
            {
                _outerSpace = value;
                mainPanel.Location = new Point(_outerSpace, 0);
                mainPanel.Width = this.Width - 2 * _outerSpace;
                flowContent.Location = new Point(0, 0);
            } 
        }

        [Category("Advanced Settings")]
        [Description("Phông chữ tiêu đề")]
        public Font TitleFont { get => lblTitle.Font; set => lblTitle.Font = value; }

        [Description("Hình ảnh nút điều hướng trái")]
        [Category("Chỉ số bo góc của khung chứa card")]
        public int BorderRadius {
            get => flowContent.BorderRadius;
            set => flowContent.BorderRadius = mainContainer.BorderRadius 
                    = mainPanel.BorderRadius = value; 
        }

        [Category("Advanced Settings")]
        [Description("Màu chữ của tiêu đề")]
        public Color TextColor { get => lblTitle.ForeColor; set => lblTitle.ForeColor = value; }

        [Category("Advanced Settings")]
        [Description("Màu sắc của layout")]
        public Color LayoutColor { get => mainPanel.BackColor; set => mainPanel.BackColor = value; }

        [Category("Advanced Settings")]
        [Description("Màu sắc của container chứa các control con")]
        public Color ContainerColor { get => flowContent.BackColor; set => flowContent.BackColor = value; }

        [Category("Advanced Settings")]
        [Description("Biểu tượng chuột khi di vào 2 nút điều hướng")]
        public Cursor ButtonCursor
        {
            get => btnLeft.Cursor;
            set
            {
                btnLeft.Cursor = value;
                btnRight.Cursor = value;
            }
        }

        [Category("Advanced Settings")]
        [Description("Số lượng phần tử con tối đa mà khung chứa card có thể chứa")]
        public int MaxChildren
        {
            get => _maxItem;
            set
            {
                _maxItem = (value < 1) ? 1 : value;
                Redraw();
                UpdateChildMinX();
            }
        }

        [Category("Advanced Settings")]
        [Description("Kích cỡ cố định của phần tử con")]
        public Size ChildSize
        {
            get => _itemSize;
            set
            {
                _itemSize = value;
                Redraw();
                UpdateChildMinX();
            }
        }

        [Category("Advanced Settings")]
        [Description("Padding của khung chứa card")]
        public Padding ContainerPadding
        {
            get => _containerPadding;
            set
            {
                _containerPadding = value;
                Redraw();
                UpdateChildMinX();
            }
        }

        [Category("Advanced Settings")]
        [Description("Khoảng cách của các phần tử con với nhau")]
        public int ChildSpacing
        {
            get => _spacing;
            set
            {
                _spacing = value;
                Redraw();
                UpdateChildMinX();
            }
        }

        [Category("Advanced Settings")]
        [Description("Lấy danh sách các phần tử con")]
        public ControlCollection Children
        {
            get => flowContent.Controls;
        }

        [Category("Advanced Settings")]
        [Description("Hiển thị nhãn tùy chỉnh")]
        public bool CustomLabelEnable
        {
            get => lblCustom.Enabled;
            set
            {
                lblCustom.Enabled = lblCustom.Visible = value;
            }
        }

        [Category("Advanced Settings")]
        [Description("Tùy chỉnh nhãn tùy chỉnh")]
        public RoundedLabel CustomLabel
        {
            get => lblCustom;
        }

        [Category("Advanced Settings")]
        [Description("Hiển thị nút hành động")]
        public bool ActionButtonEnable
        {
            get => btnAction.Enabled;
            set
            {
                btnAction.Enabled = btnAction.Visible = value;
            }
        }

        [Category("Advanced Settings")]
        [Description("Tùy chỉnh nhãn tùy chỉnh")]
        public RoundedButton ActionButton
        {
            get => btnAction;
        }


        /// <summary>
        /// Thêm một control vào cuối danh sách
        /// </summary>
        /// <param name="item">Control cần thêm</param>
        public void AddLastChild(Control item)
        {
            if (noItem > _maxItem) return;
            item.Size = _itemSize;
            item.Margin = noItem == _maxItem - 1 ? 
                new Padding(): new Padding(0, 0, _spacing, 0);
            flowContent.SafeInvoke(() => flowContent.Controls.Add(item));
            noItem++;
        }

        /// <summary>
        /// Thêm một control vào đầu danh sách
        /// </summary>
        /// <param name="item">Control cần thêm</param>
        public void AddFirstChild(Control item)
        {
            if (noItem > _maxItem) return;
            item.Size = _itemSize;
            item.Margin = noItem == _maxItem - 1 ?
                new Padding() : new Padding(0, 0, _spacing, 0);
            flowContent.Controls.Add(item);
            flowContent.Controls.SetChildIndex(item, 0);
            noItem++;
        }

        /// <summary>
        /// Thêm một control vào vị trí index
        /// </summary>
        /// <param name="item">Control cần thêm</param>
        /// <param name="index">Vị trí cần thêm</param>
        public void AddChild(Control item, int index)
        {
            if (noItem > _maxItem) return;
            item.Size = _itemSize;
            item.Margin = noItem == _maxItem - 1 ? 
                new Padding() : new Padding(0, 0, _spacing, 0); ;
            flowContent.Controls.Add(item);
            flowContent.Controls.SetChildIndex(item, index);
            noItem++;
        }

        /// <summary>
        /// Thay thế control tại vị trí index
        /// </summary>
        /// <param name="item">Control cần chèn vào</param>
        /// <param name="index">Chỉ mục chứa control cần được thay</param>
        public void ReplaceChildAtIndex(Control item, int index)
        {
            if (index < 0 || index >= noItem) return;
            item.Size = _itemSize;
            item.Margin = noItem == _maxItem - 1 ? 
                new Padding() : new Padding(0, 0, _spacing, 0); ;
            flowContent.Controls.RemoveAt(index);
            flowContent.Controls.Add(item);
        }

        /// <summary>
        /// Thay thế control toBeReplaced bằng item
        /// </summary>
        /// <param name="item">Control cần được chèn vào</param>
        /// <param name="toBeReplaced">Control cần được thay thế</param>
        public void ReplaceChild(Control item, Control toBeReplaced)
        {
            if (flowContent.Controls.Contains(toBeReplaced))
            {
                int index = flowContent.Controls.IndexOf(toBeReplaced);
                ReplaceChildAtIndex(item, index);
            }
        }

        /// <summary>
        /// Thay thế control sau control after
        /// </summary>
        /// <param name="item">Control cần chèn vào</param>
        /// <param name="after">Control ở vị trí cần chèn vào sau</param>
        public void AddSpecificChild(Control item, Control after)
        {
            if (noItem > _maxItem) return;
            item.Size = _itemSize;
            item.Margin = noItem == _maxItem - 1 ?
                new Padding() : new Padding(0, 0, _spacing, 0); ;
            flowContent.Controls.Add(item);
            flowContent.Controls.SetChildIndex(item, flowContent.Controls.IndexOf(after) + 1);
            noItem++;
        }

        /// <summary>
        /// Xóa tất cả các control con
        /// </summary>
        public void RemoveAllChild()
        {
            flowContent.Controls.Clear();
            noItem = 0;
        }

        /// <summary>
        /// Xóa control cuối cùng
        /// </summary>
        public void RemoveLastChild()
        {
            if (noItem == 0) return;
            flowContent.Controls.RemoveAt(noItem - 1);
            noItem--;
        }

        /// <summary>
        /// Xóa control đầu tiên
        /// </summary>
        public void RemoveFirstChild()
        {
            if (noItem == 0) return;
            flowContent.Controls.RemoveAt(0);
            noItem--;
        }

        /// <summary>
        /// Xóa control cụ thể
        /// </summary>
        /// <param name="item"></param>
        public void RemoveSpecificChild(Control item)
        {
            if (flowContent.Controls.Contains(item))
            {
                flowContent.Controls.Remove(item);
                noItem--;
            }
        }

        /// <summary>
        /// Xóa control tại vị trí index
        /// </summary>
        /// <param name="index">Vị trí của control cần xóa</param>
        public void RemoveChild(int index)
        {
            if (index < 0 || index >= noItem) return;
            flowContent.Controls.RemoveAt(index);
            noItem--;
        }

        /// <summary>
        /// Lấy control con tại vị trí index
        /// </summary>
        /// <param name="index">Chỉ mục của control cần được lấy</param>
        /// <returns>Control của chỉ mục truyền vào, nếu không tồn tại thì trả về null</returns>
        public Control GetChild(int index)
        {
            if (index < 0 || index >= noItem) return null;
            return flowContent.Controls[index];
        }

        /// <summary>
        /// Lấy tất cả các control con
        /// </summary>
        /// <returns></returns>
        public Control[] GetAllChild()
        {
            Control[] result = new Control[noItem];
            flowContent.Controls.CopyTo(result, 0);
            return result;
        }

        /// <summary>
        /// Đếm số control con
        /// </summary>
        /// <returns>Số lượng control con</returns>
        public int CountChild()
        {
            return noItem;
        }

        private void Redraw()
        {
            flowContent.Padding = _containerPadding;
            flowContent.Width = _itemSize.Width * _maxItem + _containerPadding.Left + _containerPadding.Right + _spacing * (_maxItem - 1) + 10;
            flowContent.Height = _itemSize.Height + _containerPadding.Top + _containerPadding.Bottom;
            this.Invalidate();
            for (int i=0; i < flowContent.Controls.Count; i++)
            {
                Control item = flowContent.Controls[i];
                if (i == flowContent.Controls.Count - 1)
                {
                    item.Margin = new Padding(0, 0, 0, 0);
                }
                else
                {
                    item.Margin = new Padding(0, 0, _spacing, 0);
                }
            }
        }

        private void InitHoldButtonTimer()
        {
            if (longClickTimer == null)
            {
                longClickTimer = new Timer();
                longClickTimer.Interval = TIMER_INTERVAL;
                longClickTimer.Tick += longClickTimer_Tick;
            }
            longClickTimer.Start();
        }

        private void longClickTimer_Tick(object sender, EventArgs e)
        {
            if (isLongClick)
            {
                if (isLeftClick)
                {
                    btnLeft.PerformClick();
                }
                else
                {
                    btnRight.PerformClick();
                }
            }
            else
            {
                if (longClickTimer == null)
                {
                    longClickTimer.Tick -= longClickTimer_Tick;
                    longClickTimer.Stop();
                    longClickTimer.Dispose();
                }
            }
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            isLongClick = true;
            isLeftClick = true;
            InitHoldButtonTimer();
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            isLongClick = false;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            this.OnViewAllClicked?.Invoke(this, e);
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            isLongClick = true;
            isLeftClick = false;
            InitHoldButtonTimer();
        }

        private void CardSlider_Resize(object sender, EventArgs e)
        {
            flowContent.Location = new Point(0, 0);
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            isLongClick = false;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (flowContent.Width > mainContainer.Width)
            {
                if (flowContent.Location.X > childMinX)
                {
                    flowContent.Location = new Point(flowContent.Location.X - SLIDE_RANGE, 0);
                    if (flowContent.Location.X <= childMinX)
                    {
                        flowContent.Location = new Point(childMinX, 0);
                    }
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (flowContent.Width > mainContainer.Width)
            {
                if (flowContent.Location.X < 0)
                {
                    flowContent.Location = new Point(flowContent.Location.X + SLIDE_RANGE, 0);
                    if (flowContent.Location.X >= 0)
                    {
                        flowContent.Location = new Point(0, 0);
                    }
                }
            }
        }

        private void UpdateChildMinX()
        {
            childMinX = -flowContent.Width + flowContent.Parent.Width - flowContent.Padding.Left - flowContent.Padding.Right;
        }
    }
}

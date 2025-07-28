using _3S_eShop.PatternDistinctive.Strategy.CharacterValidator;
using _3S_eShop.Validate;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace _3S_eShop.CustomComponents
{
    [DefaultEvent("_TextChanged")]
    public partial class AdvancedTextBox : UserControl
    {
        public AdvancedTextBox()
        {
            InitializeComponent();
        }

        #region Advanced Configuration

        // Fields
        private Color borderColor = Color.DeepSkyBlue;
        private Color borderFocusColor = Color.DodgerBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;

        #region -> Private methods

        public void SetText(string text)
        {
            textBox.Text = text;
            SetPlaceholder();
        }

        public void ClearText()
        {
            textBox.Clear();
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox.Text = placeholderText;
                textBox.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox.UseSystemPasswordChar = false;
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox.Text = "";
                textBox.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox.UseSystemPasswordChar = true;
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox.ClientRectangle, borderRadius - borderSize);
                textBox.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox.ClientRectangle, borderSize * 2);
                textBox.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        private void UpdateControlHeight()
        {
            if (textBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox.Multiline = true;
                textBox.MinimumSize = new Size(0, txtHeight);
                textBox.Multiline = false;

                this.Height = textBox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        #endregion

        #region -> Properties
        [Category("Advanced Configuration")]
        public TextBox TextBox
        {
            get { return textBox; }
        }
        
        [Category("Advanced Configuration")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Advanced Configuration")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("Advanced Configuration")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Advanced Configuration")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Advanced Configuration")]
        public HorizontalAlignment ContentAlign
        {
            get { return textBox.TextAlign; }
            set
            {
                textBox.TextAlign = value;
                this.Invalidate();
            }
        }

        [Category("Advanced Configuration")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                    textBox.UseSystemPasswordChar = value;
            }
        }

        [Category("Advanced Configuration")]
        public bool Multiline
        {
            get { return textBox.Multiline; }
            set { textBox.Multiline = value; }
        }

        [Category("Advanced Configuration")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox.BackColor = value;
            }
        }

        [Category("Advanced Configuration")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox.ForeColor = value;
            }
        }

        [Category("Advanced Configuration")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Advanced Configuration")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return textBox.Text;
            }
            set
            {
                textBox.Text = value;
                SetPlaceholder();
            }
        }

        [Category("Advanced Configuration")]
        [Description("Lấy giá trị của TextBox dưới dạng mảng các dòng")]
        public string[] TextsAsLines
        {
            get
            {
                if (isPlaceholder) return new string[] { "" };
                else return textBox.Lines;
            }
        }

        [Category("Advanced Configuration")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }

        [Category("Advanced Configuration")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                    textBox.ForeColor = value;
            }
        }

        [Category("Advanced Configuration")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                textBox.Text = "";
                SetPlaceholder();
            }
        }
        #endregion

        #region -> Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        #endregion

        // Default Event
        public event EventHandler _TextChanged;

        // TextBox -> TextChanged event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        // Change border color in focus mode
        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }

        //TextBox events
        /// <summary>
        /// textbox events attached to user control events
        /// </summary>

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        #endregion

        #region Strategy Pattern

        public BaseValidator Valid { get; set; }

        public bool IsValid(params string[] param)
        {
            return Valid.IsValid(this.Texts.Trim(), param);
        }

        public string GetInvalidMessage()
        {
            return Valid.GetInvalidMessage();
        }

       
        
        
        
        
        
        
        private BaseCharacterValidationStrategy _inputCharacterValidator;

        public BaseCharacterValidationStrategy InputCharacterValidator
        {
            get => _inputCharacterValidator;
            set
            {
                _inputCharacterValidator = value;
                if (value != null)
                {
                    textBox.KeyPress += (s, e) =>
                    {
                        if (!char.IsControl(e.KeyChar) && 
                            !_inputCharacterValidator.IsValidCharacter(e.KeyChar))
                        {
                            e.Handled = true; 
                            // Ngăn không cho ký tự được nhập vào TextBox
                        }
                    };
                }
                else
                {
                    textBox.KeyPress -= (s, e) =>
                    {
                        if (!char.IsControl(e.KeyChar) &&
                            !_inputCharacterValidator.IsValidCharacter(e.KeyChar))
                        {
                            e.Handled = true;
                            // Ngăn không cho ký tự được nhập vào TextBox
                        }
                    };
                }
            }
        }

        #endregion


    }
}

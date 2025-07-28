using System.ComponentModel;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class RatingBar: UserControl
    {
        private int ratingValue = 0;
        private bool allowEdit = true;
        private PictureBox[] stars = new PictureBox[5];

        public RatingBar()
        {
            InitializeComponent();
            stars[0] = picStar1;
            stars[1] = picStar2;
            stars[2] = picStar3;
            stars[3] = picStar4;
            stars[4] = picStar5;
            StarSize = 32;
            Spacing = 10;
            StarCursor = Cursors.Hand;
        }

        [Category("Advanced Settings")]
        [Description("Giá trị đánh giá từ 1 đến 5 sao")]
        public int RatingValue
        {
            get { return ratingValue; }
            set
            {
                if (allowEdit)
                {
                    ratingValue = value;
                    for (int i = 0; i < stars.Length; i++)
                    {
                        if (i < ratingValue)
                        {
                            stars[i].Image = Properties.Resources.star_gold_64;
                        }
                        else
                        {
                            stars[i].Image = Properties.Resources.star_border_black_64;
                        }
                    }
                }
            }
        }

        [Category("Advanced Settings")]
        [Description("Khoảng cách giữa các dấu sao")]
        public int Spacing
        {
            get { return picStar1.Margin.Right; }
            set
            {
                for (int i = 0; i < stars.Length-1; i++)
                {
                    stars[i].Margin = new Padding(0, 0, value, 0);
                }
            }
        }

        [Category("Advanced Settings")]
        [Description("Kích thước của các dấu sao")]
        public int StarSize
        {
            get { return picStar1.Size.Width; }
            set
            {
                for (int i = 0; i < stars.Length; i++)
                {
                    stars[i].Size = new System.Drawing.Size(value, value);
                }
            }
        }

        [Category("Advanced Settings")]
        [Description("Con trỏ chuột khi di chuột qua các dấu sao")]
        public Cursor StarCursor 
        {
            get { return picStar1.Cursor; }
            set
            {
                if (allowEdit)
                {
                    for (int i = 0; i < stars.Length; i++)
                    {
                        stars[i].Cursor = value;
                    }
                }
            }
        }

        [Category("Advanced Settings")]
        [Description("Cho phép người dùng chỉnh sửa đánh giá")]
        public bool AllowEdit
        {
            get => allowEdit;
            set
            {
                allowEdit = value;
                StarCursor = Cursors.Default;
            }
        }

        #region Event Handlers

        private void picStar1_Click(object sender, System.EventArgs e)
        {
            RatingValue = 1;
        }

        private void picStar2_Click(object sender, System.EventArgs e)
        {
            RatingValue = 2;
        }

        private void picStar3_Click(object sender, System.EventArgs e)
        {
            RatingValue = 3;
        }

        private void picStar4_Click(object sender, System.EventArgs e)
        {
            RatingValue = 4;
        }

        private void picStar5_Click(object sender, System.EventArgs e)
        {
            RatingValue = 5;
        }

        #endregion
    }
}

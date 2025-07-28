using _3S_eShop.Utilities;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class OrderPriceDetailControl: UserControl
    {
        public OrderPriceDetailControl()
        {
            InitializeComponent();
        }

        public OrderPriceDetailControl(string description, long money, bool isDiscount) : this()
        {
            LoadValue(description, money, isDiscount);
        }

        public void LoadValue(string description, long money, bool isDiscount = false)
        {
            lblDescription.Text = description;
            lblPrice.Text = StringUtil.FormatCurrency(money);
            if (isDiscount)
            {
                lblPrice.Text = $"- {lblPrice.Text}";
                lblPrice.ForeColor = Color.Red;
            }
        }
    }
}

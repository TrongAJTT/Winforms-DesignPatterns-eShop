using _3S_eShop.BLL.DTOs;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class CancelOrderForm: Form
    {
        public CancelOrderForm(OrderDTO orderToCancel)
        {
            InitializeComponent();
        }
    }
}
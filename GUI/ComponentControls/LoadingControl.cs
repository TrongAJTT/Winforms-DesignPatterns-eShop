using _3S_eShop.Utilities;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class LoadingControl: UserControl
    {
        public LoadingControl()
        {
            InitializeComponent();
        }

        public LoadingControl(string message)
        {
            InitializeComponent();
            label.Text = message;
        }

        public LoadingControl(string message, int secondsBeforeDispose)
        {
            InitializeComponent();
            label.Text = message;
            Task.Delay(secondsBeforeDispose * 1000).ContinueWith(t =>
            {
                this.SafeInvoke(() => Dispose());
            });
        }

        public string Message
        {
            get => label.Text;
            set => label.Text = value;
        }

    }
}

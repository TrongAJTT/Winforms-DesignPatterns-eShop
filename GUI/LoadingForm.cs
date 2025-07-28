using System.Windows.Forms;

namespace _3S_eShop.GUI
{
    public partial class LoadingForm: Form
    {
        private static LoadingForm instance;

        public static LoadingForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new LoadingForm();
                }
                return instance;
            }
        }

        public LoadingForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }
    }
}

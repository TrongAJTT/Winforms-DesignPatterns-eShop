using System.Windows.Forms;

namespace _3S_eShop.GUI.MainControls
{
    public abstract class LazyControl : UserControl
    {
        private bool isLoaded = false;

        public LazyControl()
        {
            isLoaded = false;
        }

        protected abstract void Load();

        public void LoadControl()
        {
            if (!isLoaded)
            {
                Load();
                isLoaded = true;
            }
        }

    }
}

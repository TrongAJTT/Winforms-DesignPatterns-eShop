using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public interface KeyBindingControl
    {
        void KeyDown(object sender, KeyEventArgs e);
        void KeyUp(object sender, KeyEventArgs e);
        void KeyPress(object sender, KeyPressEventArgs e);
    }
}

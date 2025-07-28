using _3S_eShop.GUI.MainControls;
using System.Drawing;

namespace _3S_eShop.PatternDistinctive.SimpleFactory
{
    /// <summary>
    /// Lớp SimpleFactory để tạo ra các lớp EmbedControl được trang trí theo các theme khác nhau.
    /// </summary>
    public class EmbedControlDecoratorFactory
    {
        public EmbedControlDecoratorFactory() { }

        public EmbedControl Decorate(string theme, EmbedControl baseControl)
        {
            if (theme == "auth")
            {
                baseControl.TitleBar.BackColor = Color.FromArgb(173, 178, 204);
                baseControl.Title.Font = new Font("Segoe UI Semibold", 14);
                baseControl.Title.ForeColor = Color.White;
            }
            return baseControl;
        }
    }
}

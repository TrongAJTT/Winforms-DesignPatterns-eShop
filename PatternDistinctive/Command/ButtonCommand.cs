using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.PatternDistinctive.Command
{
    internal class ButtonCommand : CommandBase
    {
        private Button button;

        public ButtonCommand(Button button)
        {
            this.button = button;
        }
        public override void off()
        {
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.Gray;
        }

        public override void on()
        {
            button.Enabled = true;
            button.BackColor = System.Drawing.Color.DeepSkyBlue;
        }
    }
}

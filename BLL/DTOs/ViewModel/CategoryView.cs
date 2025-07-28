using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.BLL.DTOs.ViewModel
{
    internal class CategoryView
    {
        public PictureBox PictureBox { get; set; } = new PictureBox();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}

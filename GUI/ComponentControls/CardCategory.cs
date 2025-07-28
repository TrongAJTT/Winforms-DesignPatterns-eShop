using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.Utilities;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class CardCategory : UserControl
    {
        private long _id;
        private string _description;

        public string CategoryName { get => lblName.Text; set => lblName.Text = value; }
        public long Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }

        public CardCategory()
        {
            InitializeComponent();
        }

        public CardCategory(CategoryDTO obj)
        {
            InitializeComponent();
            _id = obj.Id;
            lblName.Text = obj.Name;
            Description = obj.Description;
            
            ToolTipHelper.AppendToControl(container, Description, lblName.Text);
            ToolTipHelper.AppendToControl(picThumb, Description, lblName.Text);
            ToolTipHelper.AppendToControl(lblName, Description, lblName.Text);

            container.Click += (s,e) => MySystem.ViewCategory(_id);
            picThumb.Click += (s, e) => MySystem.ViewCategory(_id);
            lblName.Click += (s, e) => MySystem.ViewCategory(_id);

            container.Cursor = Cursors.Hand;
            picThumb.Cursor = Cursors.Hand;
            lblName.Cursor = Cursors.Hand;

            Task.Run(async () =>
            {
                var stream = await DriveHandler.DownloadFilesFromDrive(obj.Image130);
                if (picThumb.InvokeRequired)
                {
                    picThumb.Invoke(new MethodInvoker(delegate
                    {
                        picThumb.Image = Image.FromStream(stream);
                    }));
                }
                else
                {
                    picThumb.Image = Image.FromStream(stream);
                }
            });
        }
    }
}

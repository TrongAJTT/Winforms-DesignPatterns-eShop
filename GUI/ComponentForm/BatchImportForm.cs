using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class BatchImportForm: Form
    {
        private bool isCompleted = false;


        public BatchImportForm()
        {
            InitializeComponent();
            txtContent.Texts = string.Empty;
        }

        public BatchImportForm(string placeholder)
        {
            InitializeComponent();
            txtContent.Texts = placeholder;
        }

        /// <summary>
        /// Trả về giá trị của TextBox
        /// </summary>
        /// <returns>Một biến string chứa toàn bộ dữ liệu</returns>
        public string GetValue()
        {
            return isCompleted ? txtContent.Texts : string.Empty;
        }

        /// <summary>
        /// Trả về giá trị của TextBox dưới dạng mảng các dòng
        /// </summary>
        /// <returns>Một mảng string chứa các dòng dữ liệu</returns>
        public string[] GetValueAsLines()
        {
            return isCompleted ? txtContent.TextsAsLines : new string[0] ;
        }

        private void btnDone_Click(object sender, System.EventArgs e)
        {
            isCompleted = true;
            this.Close();
        }

        private void BatchImportForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                btnDone.PerformClick();
            }
        }
    }
}

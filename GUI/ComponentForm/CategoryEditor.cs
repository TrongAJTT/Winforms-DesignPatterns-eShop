using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.Command;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Facade;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace _3S_eShop.GUI
{
    public partial class CategoryEditor : Form
    {
        private CommandBase commandBase;
        private CategoryFacade categoryFacade;
        private DataGridView categoryTable;

        public CategoryEditor()
        {
            InitializeComponent();
            categoryFacade = new CategoryFacade(new CategoryDAO(), new CategoryBuilder());
            commandBase = new ButtonCommand(btnSave);
            commandBase.off();
        }

        public CategoryEditor(DataGridView categoryTable)
        {
            this.categoryTable = categoryTable;
            InitializeComponent();
            categoryFacade = new CategoryFacade(new CategoryDAO(), new CategoryBuilder());
            commandBase = new ButtonCommand(btnSave);
            commandBase.off();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đọc đường dẫn file được chọn
                    string filePath = openFileDialog.FileName;

                    // Hiển thị ảnh trong PictureBox
                    pictureBox1.Image = Image.FromFile(filePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Tùy chỉnh nếu muốn ảnh vừa khít
                    // Đánh dấu rằng đã có ảnh được chọn
                    
                    checkValidate();
                }
            }
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            checkValidate();
        }

        private void checkValidate()
        {
            if (txtDescription.Texts.Length > 0 && txtName.Texts.Length > 0 && pictureBox1.Image != null && checkDiff())
            {
                commandBase.on();
            }
            else
            {
                commandBase.off();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(categoryTable != null)
            {
               await categoryFacade.Update(categoryTable.CurrentRow.Cells["Id"].Value.ToString(), txtName.Texts, txtDescription.Texts, pictureBox1.Image);
            }
            else
            {
                await categoryFacade.Add(txtName.Texts, txtDescription.Texts, pictureBox1.Image);
            }
            this.Close();
        }

        private void CategoryEditor_Load(object sender, EventArgs e)
        {
            if (categoryTable != null)
            {
                txtName.Texts = categoryTable.CurrentRow.Cells["Name"].Value.ToString();
                txtDescription.Texts = categoryTable.CurrentRow.Cells["Description"].Value.ToString();
                pictureBox1.Image = (Image)categoryTable.CurrentRow.Cells["Image"].Value;
            }
            checkValidate();
        }
        private bool checkDiff()
        {
            if(categoryTable == null || categoryTable.CurrentRow == null)
            {
                return true; // Không có dòng nào được chọn
            }
            string description = categoryTable.CurrentRow.Cells["Description"].Value.ToString();
            string name = categoryTable.CurrentRow.Cells["Name"].Value.ToString();
            Image imageInTable = (Image)categoryTable.CurrentRow.Cells["Image"].Value; // ảnh ban đầu

            bool isTextChanged = txtDescription.Texts != description || txtName.Texts != name;
            bool isImageChanged = !CompareImages(pictureBox1.Image, imageInTable);

            return isTextChanged || isImageChanged;
        }

        private bool CompareImages(Image img1, Image img2)
        {
            if (img1 == null || img2 == null) return false;

            using (var ms1 = new MemoryStream())
            using (var ms2 = new MemoryStream())
            {
                using (var bmp1 = new Bitmap(img1))
                using (var bmp2 = new Bitmap(img2))
                {
                    bmp1.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                    bmp2.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);
                }

                byte[] hash1 = SHA256.Create().ComputeHash(ms1.ToArray());
                byte[] hash2 = SHA256.Create().ComputeHash(ms2.ToArray());

                return hash1.SequenceEqual(hash2);
            }
        }
    }
}

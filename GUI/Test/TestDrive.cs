using _3S_eShop.DAL.CloudStore;
using _3S_eShop.PatternDistinctive.Singleton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.GUI.Test
{
    public partial class TestDrive : Form
    {

        public TestDrive()
        {
            InitializeComponent();
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            List<Image> imgs = imgPicker.GetImages();
            if (imgs.Count > 0)
            {
                foreach (Image img in imgs)
                {
                    // Logic tải lên tệp lên Google Drive
                    string id = await DriveHandler.UploadImageToDriveWithinTag(img);

                    if (string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("Tải lên không thành công!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Use the Logger instance to call the Log method  
                        Logger.Instance.Log(LogLevel.Info, $"Đã tải lên ảnh {img.Tag} x{img.Size.Width} thành công với ID: " + id);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình ảnh trước khi tải lên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (txtFileId.Text != "")
            {
                // Download logic here
                string fileId = txtFileId.Text;

                // Use the MemoryStream to create the Image
                picDownload.Image = Image.FromStream(await DriveHandler.DownloadFilesFromDrive(fileId));

                // Show a success message
                Console.WriteLine("Hình ảnh đã được tải xuống thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID tệp trước khi tải xuống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

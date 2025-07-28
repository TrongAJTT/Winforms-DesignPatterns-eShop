using _3S_eShop.PatternDistinctive.Singleton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class ImagePanelPicker: UserControl
    {
        private List<string> _deleted = new List<string>();
        private List<string> _replaced= new List<string>();
        private List<string> _added = new List<string>();

        private Size pictureSize = new Size(50, 50);
        private PictureBox selectedPic;
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private bool isEditMode = false;

        public EventHandler OnImageSelected, OnImageUpdated, OnAllImageDeleted;

        public ImagePanelPicker()
        {
            InitializeComponent();
        }

        public ImagePanelPicker(bool viewOnly = false)
        {
            InitializeComponent();
            if (viewOnly)
            {
                tsBar.Size = new Size(0, 0);
                pnlContent.Dock = DockStyle.Fill;
            }
        }

        /// <summary>
        /// Thiết lập chế độ chỉ xem (ẩn hết các nút trên thanh công cụ)
        /// </summary>
        public void SetViewMode()
        {
            tsBar.Visible = false;
            pnlContent.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Thiết lập chế độ chỉnh sửa (lưu các ảnh được thêm, bị xóa). Cần gọi hàm này sau khi đã thêm các ảnh cùng id cần thiết ban đầu bằng hàm AddImageFromStream.
        /// </summary>
        public void SetEditMode()
        {
            isEditMode = true;
        }

        /// <summary>
        /// Thiết lập ảnh được chọn theo id cần tìm
        /// </summary>
        /// <param name="id">Id của ảnh được chọn</param>
        public void SetSelectedSearchFor(string id)
        {
            foreach (var pictureBox in pictureBoxes)
            {
                if (pictureBox.Tag.ToString() == id)
                {
                    this.SelectecPicture = pictureBox;
                    break;
                }
            }
        }


        /// <summary>
        /// Lấy số lượng ảnh
        /// </summary>
        /// <returns>Số lượng ảnh</returns>
        public int GetNumberOfImages()
        {
            return pictureBoxes.Count;
        }

        /// <summary>
        /// Lấy danh sách ảnh
        /// </summary>
        /// <returns>Danh sách ảnh</returns>
        public List<Image> GetImages()
        {
            return new List<Image>(pictureBoxes.ConvertAll(p =>
            {
                Image img = p.Image;
                img.Tag = p.Tag;
                return img;
            }));
        }

        /// <summary>
        /// Thiết lập kích thước ảnh mặc định
        /// </summary>
        public Size DefaultPictureSize
        {
            get => pictureSize;
            set => pictureSize = value;
        }

        /// <summary>
        /// Lấy ảnh đã chọn
        /// </summary>
        public PictureBox SelectecPicture
        {
            get => selectedPic;
            set
            {
                if (selectedPic != value)
                {
                    selectedPic = value;
                    OnImageSelected?.Invoke(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// Thêm ảnh từ Stream
        /// </summary>
        /// <param name="stream">Stream chứa dữ liệu ảnh</param>
        /// <param name="imageId">Gán id đã có sẵn cho ảnh, không sẽ tạo id tự động (lưu vào Tag)</param>
        /// <returns>Id của ảnh đã thêm</returns>
        public string AddImageFromStream(Stream stream, string imageId = null)
        {
            string id = imageId == null ? Guid.NewGuid().ToString() : imageId;
            Image independentImage = null;

            using (Image originalImage = Image.FromStream(stream))
            {
                // 2. Tạo một bản sao Bitmap hoàn toàn trong bộ nhớ.
                //    Bản sao này không còn phụ thuộc vào 'stream' gốc nữa.
                independentImage = new Bitmap(originalImage);
            }

            PictureBox pictureBox = new PictureBox
            {
                Size = pictureSize,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = independentImage,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = id,
            };
            pictureBox.Click += (p, e) => this.SelectecPicture = pictureBox;
            pictureBoxes.Add(pictureBox);
            pnlContent.Controls.Add(pictureBox);
            if (pictureBoxes.Count == 1)
            {
                this.SelectecPicture = pictureBox;
            }
            tsbChange.Enabled = tsbDelete.Enabled = true;
            return id;
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của danh sách ảnh
        /// </summary>
        /// <returns>null -> Hợp lệ || Thông báo lỗi</returns>
        public string CheckValidate()
        {
            // Kiểm tra số lượng ảnh
            if (pictureBoxes.Count < 1)
            {
                return "Vui lòng thêm ít nhất 1 ảnh.";
            }
            return null;
        }

        /// <summary>
        /// Lấy danh sách ảnh đã thêm (cần gọi hàm SetEditMode trước đó). Quy trình xử lý: Add -> Replaced -> Save
        /// </summary>
        /// <returns>Danh sách List(string) Chứa id random của các ảnh đã thêm, cần cập nhật id bằng id mới trên Drive khi thêm.</returns>
        public List<string> GetAddedImage()
        {
            return _added;
        }

        /// <summary>
        /// Lấy danh sách ảnh đã xóa (cần gọi hàm SetEditMode trước đó). Quy trình xử lý: Add -> Replaced -> Save
        /// </summary>
        /// <returns>Danh sách List(string) chứa id (cả random lẫn thật) của các ảnh đã được thay thế.</returns>
        public List<string> GetReplacedImage()
        {
            return _replaced;
        }

        /// <summary>
        /// Lấy danh sách ảnh đã xóa (cần gọi hàm SetEditMode trước đó). Quy trình xử lý: Add -> Replaced -> Save
        /// </summary>
        /// <returns>Danh sách List(string) chứa id (cả random lẫn thật) của các ảnh đã được bị xóa.</returns>
        public List<string> GetDeletedImage()
        {
            return _deleted;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Title = "Select an Image";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    try
                    {
                        // Gọi hàm AddImageFromStream để thêm ảnh từ file
                        using (Stream stream = File.OpenRead(file))
                        {
                            string id = AddImageFromStream(stream);
                            if (isEditMode)
                            {
                                _added.Add(id);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = $"Lỗi khi tải ảnh: {ex.Message}";
                        MessageBox.Show(errorMessage);
                        Logger.Instance.LogErrorException(ex, $"IMAGE PANEL PICKER - {errorMessage}");
                    }
                }
            }
        }

        private void tsbChange_Click(object sender, EventArgs e)
        {
            if (selectedPic != null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select an Image";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Thay Thế ảnh
                        selectedPic.Image = Image.FromFile(ofd.FileName);
                        // Thêm selectedPic vào danh sách đã chỉnh sửa
                        if (isEditMode)
                        {
                            _replaced.Add(selectedPic.Tag.ToString());
                        }
                        // Sự kiện OnImageUpdated
                        OnImageUpdated?.Invoke(this, new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        string errMsg = $"Lỗi tải ảnh: {ex.Message}";
                        MessageBox.Show(errMsg);
                        Logger.Instance.LogErrorException(ex, $"IMAGE PANEL PICKER - {errMsg}");
                    }
                }
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (selectedPic != null)
            {
                // Thêm selectedPic vào danh sách đã xóa
                if (isEditMode)
                {
                    _deleted.Add(selectedPic.Tag.ToString());
                }
                // Xóa ảnh
                pictureBoxes.Remove(selectedPic);
                pnlContent.Controls.Remove(selectedPic);
                selectedPic.Dispose();
                selectedPic = null;
                // Cập nhật lại ảnh được chọn
                if (pictureBoxes.Count > 0)
                {
                    this.SelectecPicture = pictureBoxes[0];
                }
                else
                {
                    tsbChange.Enabled = tsbDelete.Enabled = false;
                    this.OnAllImageDeleted?.Invoke(this, new EventArgs());
                }
            }
        }
    }
}

using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.DAL;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.PatternDistinctive.Singleton;
using System.Drawing;
using _3S_eShop.DAL.DAOs;

namespace _3S_eShop.PatternDistinctive.Facade
{
    internal class BrandFacade
    {
        private ICrudRepository<BrandDTO, long> repository;
        private BrandBuilder brandBuilder;

        public BrandFacade(ICrudRepository<BrandDTO, long> repository, BrandBuilder brandBuilder)
        {
            this.repository = repository;
            this.brandBuilder = brandBuilder;
        }

        public async Task GetViews(DataGridView dataGridView, long id)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("Id", "ID");

            var imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Ảnh",
                Name = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView.Columns.Add(imageColumn);
            dataGridView.Columns.Add("Name", "Tên");
            dataGridView.Columns.Add("Description", "Mô tả");

            List<BrandDTO> list = repository.FindMatch("category_id", id.ToString());

            var tasks = list.Select(async p =>
            {
                var view = new CategoryView();
                using (var stream = await DriveHandler.DownloadFilesFromDrive(p.Image130))
                {
                    view.PictureBox.Image = Image.FromStream(stream);
                }
                view.Description = p.Description;
                view.Name = p.Name;
                return (Id: p.Id, View: view);
            });

            var views = await Task.WhenAll(tasks);

            foreach (var item in views)
            {
                dataGridView.Rows.Add(item.Id, item.View.PictureBox.Image, item.View.Name, item.View.Description);
            }
        }


        public async Task Add(long categoryId, string name, string description, Image image)
        {
            try
            {
                var resizedImage40 = ImageHelper.ResizeImage(image, 40, 40);
                var resizedImage130 = ImageHelper.ResizeImage(image, 130, 130);

                using (var stream40 = ImageToMemoryStream(resizedImage40, ImageFormat.Jpeg))
                using (var stream130 = ImageToMemoryStream(resizedImage130, ImageFormat.Jpeg))
                {
                    var image40Id = await DriveHandler.UploadImageFromStreamMemoryToDrive(stream40);
                    var image130Id = await DriveHandler.UploadImageFromStreamMemoryToDrive(stream130);

                    repository.Add(
                        brandBuilder
                            .SetCategoryId(categoryId)
                            .SetImage40(image40Id)
                            .SetImage130(image130Id)
                            .SetName(name)
                            .SetDescription(description)
                            .Build()
                    );
                }

                MySystem.ShowToastMessageAtTopRight("Thêm thương hiệu thành công");

            }
            catch (Exception ex)
            {
                Logger.Instance.LogErrorException(ex, $"BRAND FACADE - Lỗi khi thêm danh mục: {ex}");
                Console.WriteLine(ex.ToString());
            }
        }

        public static MemoryStream ImageToMemoryStream(Image image, ImageFormat format)
        {
            var ms = new MemoryStream();
            image.Save(ms, format);
            ms.Position = 0; // Đặt lại con trỏ stream về đầu
            return ms;
        }

        public bool Delete(DataGridView dataGridView)
        {
            BrandDTO brand = repository.GetById((long)dataGridView.CurrentRow.Cells["Id"].Value);

            if (brand != null)
            {
                // Kiểm tra xem có sản phẩm nào liên quan đến thương hiệu này không
                ProductDAO productDAO = new ProductDAO();
                if (productDAO.AnyMatch("brand_id", brand.Id.ToString()))
                {
                    MessageBox.Show("Không thể xóa thương hiệu này vì có sản phẩm liên quan đến nó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Xóa ảnh từ Google Drive
                DriveHandler.DeleteFileFromDrive(brand.Image40);
                DriveHandler.DeleteFileFromDrive(brand.Image130);

                // Xóa danh mục
                repository.DeleteById(brand.Id);
                MySystem.ShowToastMessageAtTopRight("Xóa thương hiệu thành công");
                return true;
            }
            return false;
        }

        internal BrandDTO GetById(long value)
        {
            return repository.GetById(value);
        }

        public async Task<CategoryView> GetView(string id)
        {
            BrandDTO brand = repository.GetById(long.Parse(id));
            if (brand != null)
            {
                var view = new CategoryView();
                using (var stream = await DriveHandler.DownloadFilesFromDrive(brand.Image130))
                {
                    view.PictureBox.Image = Image.FromStream(stream);
                }
                view.Description = brand.Description;
                view.Name = brand.Name;
                return view;
            }
            return null;
        }

        public async Task Update(string id, long categoryId, string name, string description, Image image)
        {
            try
            {
                var resizedImage40 = ImageHelper.ResizeImage(image, 40, 40);
                var resizedImage130 = ImageHelper.ResizeImage(image, 130, 130);

                using (var stream40 = ImageToMemoryStream(resizedImage40, ImageFormat.Jpeg))
                using (var stream130 = ImageToMemoryStream(resizedImage130, ImageFormat.Jpeg))
                {
                    var image40Id = await DriveHandler.UploadImageFromStreamMemoryToDrive(stream40);
                    var image130Id = await DriveHandler.UploadImageFromStreamMemoryToDrive(stream130);
                    long brandId = long.Parse(id);
                    repository.Update(brandId,
                        brandBuilder
                            .SetCategoryId(categoryId)
                            .SetImage40(image40Id)
                            .SetImage130(image130Id)
                            .SetName(name)
                            .SetDescription(description)
                            .Build()
                    );
                }
                MySystem.ShowToastMessageAtTopRight("Cập nhật thương hiệu thành công");
            }
            catch (Exception ex)
            {
                Logger.Instance.LogErrorException(ex, $"BRAND FACADE - Lỗi khi cập nhật danh mục: {ex}");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

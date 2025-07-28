using _3S_eShop.BLL.DTOs;
using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.DAL;
using _3S_eShop.DAL.CloudStore;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Singleton;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.PatternDistinctive.Facade
{
    internal class CategoryFacade
    {
        private ICrudRepository<CategoryDTO, long> repository;
        private CategoryBuilder categoryBuilder;
        public CategoryFacade(ICrudRepository<CategoryDTO, long> repository, CategoryBuilder categoryBuilder)
        {
            this.repository = repository;
            this.categoryBuilder = categoryBuilder;
        }

        public async Task GetViews(DataGridView dataGridView)
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

            List<CategoryDTO> list = repository.GetAll();

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


        public async Task Add(string name, string description, Image image)
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
                        categoryBuilder
                            .SetImage40(image40Id)
                            .SetImage130(image130Id)
                            .SetName(name)
                            .SetDescription(description)
                            .Build()
                    );
                }


            }
            catch (Exception ex)
            {
                Logger.Instance.LogErrorException(ex, $"CATEGORY FACADE - Lỗi khi thêm danh mục: {ex}");
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

        public void Delete(DataGridView dataGridView)
        {
            CategoryDTO category = repository.GetById((long)dataGridView.CurrentRow.Cells["Id"].Value);
            if (category != null)
            {
                // Xóa ảnh từ Google Drive
                 DriveHandler.DeleteFileFromDrive(category.Image40);
                 DriveHandler.DeleteFileFromDrive(category.Image130);

                // Xóa danh mục
                repository.DeleteById(category.Id);
            }
        }

        internal CategoryDTO GetById(long value)
        {
            return repository.GetById(value);
        }

        public async Task<CategoryView> GetView(string id)
        {
            CategoryDTO category = repository.GetById(long.Parse(id));
            if (category != null)
            {
                var view = new CategoryView();
                using (var stream = await DriveHandler.DownloadFilesFromDrive(category.Image130))
                {
                    view.PictureBox.Image = Image.FromStream(stream);
                }
                view.Description = category.Description;
                view.Name = category.Name;
                return view;
            }
            return null;
        }

        public async Task Update(string id,string name, string description, Image image)
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
                    long categoryId = long.Parse(id);
                    repository.Update(categoryId,
                        categoryBuilder
                            .SetImage40(image40Id)
                            .SetImage130(image130Id)
                            .SetName(name)
                            .SetDescription(description)
                            .Build()
                    );
                }
            }
            catch (Exception ex)
            {
                Logger.Instance.LogErrorException(ex, $"CATEGORY FACADE - Lỗi khi cập nhật danh mục: {ex}");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

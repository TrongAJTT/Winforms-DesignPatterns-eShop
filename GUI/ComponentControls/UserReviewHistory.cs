using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.PatternDistinctive.Builder;
using _3S_eShop.Utilities;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class UserReviewHistory: UserControl
    {
        public UserReviewHistory()
        {
            InitializeComponent();
            InitializeEvent();
            UpdateReviewsSearch();
        }

        // Khởi tạo sự kiện
        private void InitializeEvent()
        {
            paginationSelector.OnPageChanged += (s, e) => SearchForReviews();
            paginationSelector.OnPageSizeChanged += (s, e) => UpdateReviewsSearch();
        }

        // Tạo câu truy vấn tìm kiếm theo bộ lọc
        private PagingQueryBuilder GetQueryBuilder()
        {
            return new PagingQueryBuilder("User_Review", "created_at", "id", true)
                .AddSpecific($"user_id = @userId")
                .SetDesc(true);
        }

        // Dọn dữ liệu trong flowReview
        private void ClearDataInFlow()
        {
            flowReviews.Controls.Clear();
            picOverlay.Visible = true;
            picOverlay.Image = Properties.Resources.ic_loading_gif;
        }

        // Cập nhật số lượng sản phẩm tìm kiếm được cho pagingSelector và tìm kiếm sản phẩm
        private async void UpdateReviewsSearch()
        {
            ClearDataInFlow();
            // Lấy số dòng
            long numberOfItem = (long)await Task.Run(() =>
            DataProvider.Instance.ExecuteScalar(GetQueryBuilder().SetSelectCount().Build(), MainForm.User.Id));
            // Cập nhật giao diện
            paginationSelector.MaxSize = numberOfItem;
            // Tìm kiếm item
            SearchForReviews();
        }

        // Tìm kiếm sản phẩm
        private void SearchForReviews()
        {
            ClearDataInFlow();
            // Tạo câu truy vấn phân trang toàn bảng
            string query = GetQueryBuilder()
                .SetSelect("product_id")
                .SetPage(paginationSelector.CurrentPage)
                .SetPageSize(paginationSelector.PageSize).Build();
            Task.Run(() =>
            {
                // Lấy dữ liệu và gán vào bảng
                List<object> list = DataProvider.Instance.ExecuteQuerryAsColumn(query, MainForm.User.Id);
                // Hiện kết quả
                if (list.Count > 0)
                {
                    // Ẩn nhãn ghi đè
                    picOverlay.SafeInvokeSetVisible(false);
                    // Tạo danh sách sản phẩm
                    foreach (long id in list)
                    {
                        flowReviews.SafeInvoke(() =>
                        {
                            // Tạo đối tượng điều khiển đánh giá
                            var control = new UserReviewControl(MainForm.User.Id, id, true);
                            // Thêm vào danh sách
                            flowReviews.Controls.Add(control);
                        });
                    }
                }
                else
                {
                    picOverlay.SafeInvokeSetImage(Properties.Resources.no_data_found);
                }
            });
        }
    }
}

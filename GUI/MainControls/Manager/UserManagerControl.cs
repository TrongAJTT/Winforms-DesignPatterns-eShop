using _3S_eShop.DAL.DAOs;
using _3S_eShop.GUI.ComponentForm;
using _3S_eShop.PatternDistinctive.Decorator;
using _3S_eShop.PatternDistinctive.Facade;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3S_eShop.GUI.MainControls.Manager
{
    public partial class UserManagerControl : UserControl
    {
        private IUser _userService;           // sửa lại cho đúng interface IUser
        private int _totalRecords;
        private List<string> activeFilter;
        UserFacade UserFacade;
        public UserManagerControl()
        {
           

            InitializeComponent();
            // Cấu hình để hiển thị cả thanh cuộn ngang và dọc
            dataGridView1.ScrollBars = ScrollBars.Both;
            UserFacade = new UserFacade(new UserDAO());
            // Bắt buộc cột không tự giãn ra toàn bảng (tránh mất scrollbar ngang)

            // 1) Khởi tạo DefaultUser và bọc decorator nếu cần
            _userService = new DefaultUser();
            activeFilter = new List<string>();
            // 2) Thiết lập pagination lần đầu
            InitializePagination();

            // 3) Đăng ký event cho pagingSelector
            pagingSelector.OnPageChanged += PagingSelector_OnPageChanged;
            pagingSelector.OnPageSizeChanged += PagingSelector_OnPageSizeChanged;

            // 4) Xử lý menu item click
            menuStrip1.ItemClicked += ToolStripMenuItem_Click;
        }

        private void InitializePagination()
        {
            // Lấy page đầu và tổng bản ghi
            var firstPage = _userService.GetUserList(
                page: 1,
                pageSize: 10,
                out _totalRecords,
                additionalWhereClause: "role_id = 2"
            );

            // Cấu hình pagingSelector
            pagingSelector.MaxSize = _totalRecords;
            pagingSelector.PageSize = 10;
            pagingSelector.CurrentPage = 1;

            // Bind dữ liệu
            dataGridView1.DataSource = firstPage;
        }

        private void PagingSelector_OnPageChanged(object sender, EventArgs e)
        {
            LoadCurrentPage();
        }

        private void PagingSelector_OnPageSizeChanged(object sender, EventArgs e)
        {
            // Khi đổi pageSize, reset về trang 1 và load lại
            pagingSelector.CurrentPage = 1;
            LoadCurrentPage();
        }

        private void LoadCurrentPage()
        {
            int page = (int)pagingSelector.CurrentPage;
            int pageSize = (int)pagingSelector.PageSize;

            var dt = _userService.GetUserList(
                page: page,
                pageSize: pageSize,
                out _totalRecords,
                additionalWhereClause: null
            );

            // Cập nhật MaxSize (nếu tổng thay đổi)
            pagingSelector.MaxSize = _totalRecords;

            dataGridView1.DataSource = dt;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                string key = menuItem.Tag.ToString();

                // Toggle trong danh sách activeFilters
                if (menuItem.Checked)
                {
                    // nếu trước đó đã checked, thì bây giờ là uncheck → bỏ filter
                    menuItem.Checked = false;
                    activeFilter.Remove(key);
                }
                else
                {
                    // nếu trước đó chưa checked, bây giờ là check → thêm filter
                    menuItem.Checked = true;
                    activeFilter.Add(key);
                }

                // 1) Xây dựng lại chuỗi decorators
                rebuildFilter();

                // 2) Load lại page đầu (hoặc giữ nguyên current page tuỳ UX)
                LoadCurrentPage();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "is_active")
            {
                // Toggle trạng thái checkbox
                var currentValue = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if(currentValue == true)
                {
                    BanUserForm banUserForm = new BanUserForm(dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString(), (long)dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    banUserForm.ShowDialog();
                    LoadCurrentPage();
                }
                else
                {
                    UserFacade.UpdateActive((long)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value,!currentValue,"");
                    MessageBox.Show("Bạn đã Active tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadCurrentPage();
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !currentValue;
                
            }
        }

        private void rebuildFilter()
        {
            _userService = new DefaultUser();
            activeFilter.ForEach(key =>
            {
                _userService = SimpleDecoratorFactory.CreateUser(key, _userService);
            });
        }

        private void tsmiSeeInfo_Click(object sender, EventArgs e)
        {
            var uid = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            new UserInfoViewer(Convert.ToInt64(uid)).ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            tsmiSeeInfo.Enabled = dataGridView1.SelectedCells.Count > 0;
        }
    }
}
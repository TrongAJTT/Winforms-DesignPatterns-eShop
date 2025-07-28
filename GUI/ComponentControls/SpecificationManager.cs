using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using _3S_eShop.PatternDistinctive.Strategy;
using _3S_eShop.Utilities;

namespace _3S_eShop.GUI.ComponentControls
{
    public partial class SpecificationManager: UserControl
    {
        private Dictionary<string, string> _specs = new Dictionary<string, string>();
        private int column = 1;
        int editIndex = -1;

        public SpecificationManager()
        {
            InitializeComponent();
            InitializeContextMenu();
            ToolTipHelper.AppendToControl(
                btnAdd,
                "Thêm thông số"
            );
            lblError.Text = "";
            txtKey.Valid = new SpecKeyValidator();
            txtValue.Valid = new TextLengthConstraintValidator();
        }


        /// <summary>
        /// Trả về danh sách các thông số đã thêm vào => SortedList<string,string>
        /// </summary>
        public Dictionary<string, string> Value
        {
            get
            {
                Dictionary<string, string> result = new Dictionary<string, string>();
                foreach (ListViewItem item in listViewTags.Items)
                {
                    result.Add(item.Text, item.SubItems[1].Text);
                }
                return result;
            }
            set
            {
                listViewTags.Items.Clear();
                _specs.Clear();
                foreach (var item in value)
                {
                    txtKey.Focus();
                    txtKey.Texts = item.Key;
                    txtValue.Focus();
                    txtValue.Texts = item.Value;
                    btnAdd_Click(null, null);
                }
            }
        }

        /// <summary>
        /// Số cột của thẻ thông số
        /// </summary>
        public int Column { get => column; set => column = value; }

        /// <summary>
        /// Kiểm tra tính hợp lệ của danh sách thông số
        /// </summary>
        /// <returns>null -> Hợp lệ || Thông báo lỗi</returns>
        public string CheckValidate()
        {
            if (_specs.Count < 2)
            {
                return "Vui lòng thêm ít nhất 2 thông số.";
            }
            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra hợp lệ
            if (!MySystem.ValidateTemplate(txtKey, lblError, _specs.Keys.ToArray())) return;
            if (!MySystem.ValidateTemplate(txtValue, lblError)) return;

            // Thêm cặp thông số vào danh sách
            _specs.Add(txtKey.Texts, txtValue.Texts);

            // Tạo thẻ thông số và thêm vào list view
            var item = new ListViewItem(txtKey.Texts);
            item.SubItems.Add(txtValue.Texts);
            if (editIndex != -1)
            {
                listViewTags.Items.Insert(editIndex, item);
                editIndex = -1;
            }
            else
            {
                listViewTags.Items.Add(item);
            }

            // Xóa thông tin trong ô nhập
            txtKey.Texts = txtValue.Texts = "";
            txtKey.Focus();

            InitializeContextMenu();
        }

        private void tsmiMoveFirst_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(0);
        }

        private void InitializeContextMenu()
        {
            if (listViewTags.SelectedItems.Count == 0)
            {
                tsmiPosition.Enabled = false;
                tsmiEdit.Enabled = false;
                tsmiDelete.Enabled = false;
            }
            else if (listViewTags.SelectedItems.Count == 1)
            {
                tsmiPosition.Enabled = true;
                tsmiEdit.Enabled = true;
                tsmiDelete.Enabled = true;
            }
            else
            {
                tsmiPosition.Enabled = false;
                tsmiEdit.Enabled = false;
                tsmiDelete.Enabled = true;
            }
            tsmiDeleteAll.Enabled = listViewTags.Items.Count > 0;
        }

        private void listViewTags_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            InitializeContextMenu();
        }

        private void tsmiMoveUp_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(listViewTags.SelectedItems[0].Index - 1);
        }

        private void MoveItemToPosition(int position)
        {
            ListViewItem item = listViewTags.SelectedItems[0];
            int index = item.Index;
            if (index > 0 && index < listViewTags.Items.Count - 1)
            {
                listViewTags.Items.Remove(item);
                listViewTags.Items.Insert(position, item);
            }
            _specs.Remove(item.Text);
        }

        private void tsmiMoveP5_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(listViewTags.SelectedItems[0].Index - 5);
        }

        private void tsmiMoveP4_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(listViewTags.SelectedItems[0].Index - 4);
        }

        private void tsmiMoveP3_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(listViewTags.SelectedItems[0].Index - 3);
        }

        private void tsmiMoveP2_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(listViewTags.SelectedItems[0].Index - 2);
        }

        private void tsmiMoveN2_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(listViewTags.SelectedItems[0].Index + 2);
        }

        private void tsmiMoveN3_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(listViewTags.SelectedItems[0].Index + 3);
        }

        private void tsmiMoveN4_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(listViewTags.SelectedItems[0].Index + 4);
        }

        private void tsmiMoveN5_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(listViewTags.SelectedItems[0].Index + 5);
        }

        private void tsmiMoveDown_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(listViewTags.SelectedItems[0].Index + 1);
        }

        private void tsmiMoveLast_Click(object sender, EventArgs e)
        {
            MoveItemToPosition(listViewTags.Items.Count - 1);
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            ListViewItem item = listViewTags.SelectedItems[0];
            txtKey.Focus();
            txtKey.Texts = item.Text;
            txtValue.Focus();
            txtValue.Texts = item.SubItems[1].Text;
            editIndex = item.Index;
            listViewTags.Items.Remove(item);
            _specs.Remove(item.Text);
            InitializeContextMenu();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            var items = listViewTags.SelectedItems;
            foreach (ListViewItem item in items)
            {
                listViewTags.Items.Remove(item);
                _specs.Remove(item.Text);
            }
        }

        private void tsmiDeleteAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả thông số không?", "Xóa tất cả thông số", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listViewTags.Items.Clear();
                _specs.Clear();
                InitializeContextMenu();
            }
        }
    }
}

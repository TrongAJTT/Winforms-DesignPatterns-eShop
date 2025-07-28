using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _3S_eShop.CustomControls
{
    public class AlikeTableLayout : TableLayoutPanel
    {
        private List<TableCursor> _lostCells = new List<TableCursor>();
        private List<int> maxHeightPerRow = new List<int>();
        private TableCursor _cur;

        public AlikeTableLayout()
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Height = 0;
            _cur = new TableCursor(3);
            ColumnCount = 3;
            RowCount = 1;
            maxHeightPerRow.Add(0);
            CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
        }

        public new int RowCount
        {
            get => base.RowCount;
            set
            {
                base.RowCount = value;
                for (int i = 0; i < value; i++)
                {
                    if (RowStyles.Count <= i) RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    else RowStyles[i] = new RowStyle(SizeType.AutoSize);
                }
            }
        }

        public new int ColumnCount
        {
            get => base.ColumnCount;
            set
            {
                // Lưu danh sách Controls
                Control[] controls = new Control[ColumnCount * RowCount];
                this.Controls.CopyTo(controls, 0);
                // Thực hiện đổi Column Count
                base.ColumnCount = value;
                _cur.MaxColumns = value;
                // Format lại column
                for (int i = 0; i < value; i++)
                {
                    if (ColumnStyles.Count <= i) ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100/value));
                    else ColumnStyles[i] = new ColumnStyle(SizeType.Percent, 100 / value);
                }
                // Reset Controls và cursor
                Controls.Clear();
                RowCount = 1;
                maxHeightPerRow = new List<int> { 0 };
                _cur.Reset();
                // Gán lại Controls
                foreach (Control control in controls)
                {
                    if (control != null)
                    {
                        AddControl(control);
                    }
                }
            }
        }

        public void AddControl(Control control)
        {
            Controls.Add(control, _cur.Col, _cur.Row);
            // Nếu control cao hơn chiều cao của row hiện tại thì cập nhật lại height.
            if (maxHeightPerRow[_cur.Row] < control.Height + control.Margin.Top + control.Margin.Bottom)
            {
                maxHeightPerRow[_cur.Row] = control.Height + control.Margin.Top + control.Margin.Bottom;
                UpdateHeight();
            }
            // Cập nhật con trỏ
            if (_cur.NextCell())
            {
                RowCount++;
                maxHeightPerRow.Add(0);
            }
        }

        //public void AddControl(Control control, int row, int column)
        //{
        //    // Tạo con trỏ mới để kiểm tra xem có cần thêm dòng mới không
        //    TableCursor newCur = new TableCursor() { Col = column, Row = row };
        //    // Nếu con trỏ hiện tại nhỏ hơn con trỏ mới
        //    if (_cur.CompareTo(newCur) < 0)
        //    {
        //        if (_lostCells.Contains(newCur))
        //        {
        //            _lostCells.Remove(newCur);
        //            Controls.Add(control, newCur.Col, newCur.Row);
        //        }
        //    }
        //    // Nếu con trỏ hiện tại bằng con trỏ mới
        //    else if (_cur.CompareTo(newCur) == 0)
        //    {
        //        AddControl(control);
        //    }
        //    // Nếu con trỏ hiện tại lớn hơn con trỏ mới
        //    else
        //    {
        //        while(_cur.CompareTo(newCur) < 0)
        //        {
        //            _lostCells.Add(_cur);
        //            if (_cur.NextCell())
        //            {
        //                RowCount++;
        //            }
        //        }
        //        _lostCells.Add(newCur);
        //    }
        //}

        private void UpdateHeight()
        {
            Height = maxHeightPerRow.Sum();
        }

    }

    /// <summary>
    /// Lớp con trỏ cho Table, giúp quản lý vị trí hiện tại của con trỏ
    /// </summary>
    class TableCursor
    {
        private int _colCursor = 0, _rowCursor = 0;
        private int _maxColumns = 0;

        /// <summary>
        /// Cột hiện tại của con trỏ
        /// </summary>
        public int Col { get => _colCursor; set => _colCursor = value; }
        
        /// <summary>
        /// Dòng hiện tại của con trỏ
        /// </summary>
        public int Row { get => _rowCursor; set => _rowCursor = value; }

        /// <summary>
        /// Số cột tối đa
        /// </summary>
        public int MaxColumns { get => _maxColumns; set => _maxColumns = value; }

        /// <summary>
        /// Khởi tạo con trỏ
        /// </summary>
        /// <param name="maxColumns">Số cột tối đa</param>
        public TableCursor(int maxColumns = -1)
        {
            _colCursor = 0;
            _rowCursor = 0;
            _maxColumns = maxColumns;
        }

        /// <summary>
        /// Di chuyển con trỏ đến ô trước đó
        /// </summary>
        /// <returns>`True` nếu có sự thay đổi dòng, ngược lại `False`</returns>
        public bool PrevCell()
        {
            _colCursor--;
            if (_colCursor < 0)
            {
                _colCursor = _maxColumns - 1;
                _rowCursor--;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Di chuyển con trỏ đến ô tiếp theo
        /// </summary>
        /// 
        /// <returns>`True` nếu có sự thay đổi dòng, ngược lại `False`</returns>
        public bool NextCell()
        {
            _colCursor++;
            if (_colCursor == _maxColumns)
            {
                _colCursor = 0;
                _rowCursor++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Đặt lại con trỏ về vị trí ban đầu
        /// </summary>
        public void Reset()
        {
            _colCursor = 0;
            _rowCursor = 0;
        }

        /// <summary>
        /// So sánh vị trí của con trỏ với một con trỏ khác (so sánh theo vị trí dòng trước, cột sau)
        /// </summary>
        /// <param name="obj">Con trỏ khác cần được so sánh</param>
        /// <returns>-1 nếu bé hơn, 0 nếu bằng, 1 nếu lớn hơn</returns>
        public int CompareTo(TableCursor obj)
        {
            if (_rowCursor < obj.Row) return -1;
            else if (_rowCursor > obj.Row) return 1;
            else
            {
                if (_colCursor < obj.Col) return -1;
                else if (_colCursor > obj.Col) return 1;
                else return 0;
            }
        }
    }
}

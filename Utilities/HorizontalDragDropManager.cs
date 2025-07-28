using System.Drawing;
using System.Windows.Forms;

namespace _3S_eShop.Utilities
{
    class HorizontalDragDropManager
    {
        private Control _draggedControl;
        private Point _dragStartLocation;
        private bool _isDragging;
        private int minX, maxX;

        public HorizontalDragDropManager(Control control)
        {
            _draggedControl = control;
            minX = int.MinValue;
            maxX = int.MaxValue;
        }

        public HorizontalDragDropManager(Control control, int minX, int maxX)
        {
            _draggedControl = control;
            this.minX = minX;
            this.maxX = maxX;
        }

        public void StartDrag(MouseEventArgs e)
        {
            _dragStartLocation = e.Location;
            _isDragging = true;
        }

        public void DragOver(MouseEventArgs e)
        {
            if (_isDragging)
            {
                // Tính toán vị trí mới của control được kéo
                int newX = e.X - (_dragStartLocation.X + 10);

                // Đảm bảo control không vượt quá min và max
                if (newX < minX) newX = minX;
                if (newX > maxX) newX = maxX;

                // Di chuyển control đến vị trí mới
                _draggedControl.Location = new Point(newX, _draggedControl.Location.Y);
            }
        }

        public void EndDrag()
        {
            _isDragging = false;
        }

    }
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace _3S_eShop.CustomControls
{
    public class RoundedFlowLayoutPanel: FlowLayoutPanel
    {
        private int borderSize = 0;
        private int borderRadius = 30;
        private Color borderColor = Color.DeepSkyBlue;

        // Thuộc tính
        [Category("Advanced Configuration")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Advanced Configuration")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Advanced Configuration")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Advanced Configuration")]
        public Color TextColor
        {
            get => this.ForeColor;
            set => this.ForeColor = value;
        }

        public RoundedFlowLayoutPanel()
        {
            this.Size = new Size(150, 40);
            this.BackColor = Color.DeepSkyBlue;
            this.ForeColor = Color.White;
        }

        // Phương thức
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            gp.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            gp.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            gp.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            gp.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);

            gp.CloseFigure();
            return gp;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new Rectangle(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new Rectangle(1, 1, this.Width - 1, this.Height - 1);

            if (borderRadius > 2)   // Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    // Button surface
                    this.Region = new Region(pathSurface);
                    // Draw button color for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    // Button border
                    if (borderSize >= 1)
                    {
                        // Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else    // Normal button
            {
                // Button surface
                this.Region = new Region(rectSurface);
                // Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            if (Parent != null)
            {
                base.OnHandleCreated(e);
                this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
            }
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }

    }
}

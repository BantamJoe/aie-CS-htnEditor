using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTNMaker
{
    public partial class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            Rectangle drawRect = new Rectangle(0, 0, Width, Height);

            using (Pen gridPen = new Pen(Color.Beige))
            {
                gridPen.Width = 2;
                using (Brush bgBrush = new SolidBrush(Color.Gray))
                {
                    g.FillRectangle(bgBrush, drawRect);
                    for (int x = 0; x < Width; x += 40)
                    {
                        g.DrawLine(gridPen, new Point(x, 0), new Point(x, Height));
                    }
                    for (int y = 0; y < Height; y += 40)
                    {
                        g.DrawLine(gridPen, new Point(0, y), new Point(Width, y));
                    }
                }
            }
            using (Pen connectionPen = new Pen(Color.Black, 2))
            {
                foreach (Control control in Controls)
                {
                    NodeControl node = control as NodeControl;
                    if (node != null)
                    {
                        //HACK maybe have tranparent panel above, draw onto that
                        node.PaintConnections(g, connectionPen);
                    }
                }
            }
        }
    }
}

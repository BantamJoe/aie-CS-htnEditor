using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTNMaker
{
    public partial class NodeControl : UserControl
    {
        private Point mouseDownLocation;
        public NodeControl()
        {
            InitializeComponent();
        }

        private void NodeControl_Paint(object sender, PaintEventArgs e)
        {
            //TODO print name at top of control
            //TODO draw lines to any child nodes
        }

        private void NodeControl_DoubleClick(object sender, EventArgs e)
        {
            //TODO open or close
        }

        private void NodeControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void NodeControl_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Top += (e.Y - mouseDownLocation.Y);
                this.Left += (e.X - mouseDownLocation.X);
            }
        }
    }
}

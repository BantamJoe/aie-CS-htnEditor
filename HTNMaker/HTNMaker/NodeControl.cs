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
        public Action ObservedAction {get; set;}

        private NodeControl parentNode;
        public NodeControl ParentNode { get; }

        private List<NodeControl> childNodes;

        private Point mouseDownLocation;
        public NodeControl(Action action, NodeControl parentNode = null)
        {
            InitializeComponent();
            childNodes = new List<NodeControl>();
            this.parentNode = parentNode;
            if(parentNode != null)
            {
                closeButton.Hide();
            }
            ObservedAction = action;
            titleLabel.DataBindings.Add(new Binding("Text", ObservedAction, "Name"));
            
        }

        private void NodeControl_Paint(object sender, PaintEventArgs e)
        {
            //TODO draw lines to any child nodes
        }

        private void NodeControl_DoubleClick(object sender, EventArgs e)
        {
            //TODO open or close
            // TODO on opening, create children and add to parent as controls
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }
    }
}

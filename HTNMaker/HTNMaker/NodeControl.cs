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
        public static int NODE_WIDTH = 150;
        public static int NODE_HEIGHT = 80;
        public static int NODE_VERTICAL_SPACING = 100;
        public static int NODE_HORIZONTAL_SPACING = 200;
        public Action ObservedAction {get; set;}

        private NodeControl parentNode;
        public NodeControl ParentNode { get; }

        private List<NodeControl> childNodes;

        private Point mouseDownLocation;

        bool open;
        public NodeControl(Action action, NodeControl parentNode = null)
        {
            InitializeComponent();
            DoubleBuffered = true;
            Width = NODE_WIDTH;
            Height = NODE_HEIGHT;
            open = false;
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

        public void PaintConnections(Graphics g, Pen p)
        {
            Point bottomCenter = new Point(Location.X + Width / 2, Location.Y + Height);
            foreach (NodeControl childNode in childNodes)
            {
                Point childTop = new Point(childNode.Location.X + childNode.Width / 2, childNode.Location.Y);
                g.DrawLine(p, bottomCenter, childTop);
            }
        }

        private void NodeControl_DoubleClick(object sender, EventArgs e)
        {
            //TODO open or close
            // TODO on opening, create children and add to parent as controls
            open = !open;
            if (open)
            {
                foreach(Action childAction in ObservedAction.Children)
                {
                    NodeControl childNode = new NodeControl(childAction, this);
                    Parent.Controls.Add(childNode);
                    childNodes.Add(childNode);
                }
                int rowLocation = Location.Y + NODE_VERTICAL_SPACING;
                
                int xLocation = Math.Max(Location.X - ((childNodes.Count - 1) * NODE_HORIZONTAL_SPACING / 2), 0);
                foreach(NodeControl childNode in childNodes)
                {
                    childNode.Location = new Point(xLocation, rowLocation);
                    childNode.findOpenSpace();
                    rowLocation = childNode.Location.Y;
                    xLocation = childNode.Location.X + NODE_HORIZONTAL_SPACING;
                }
                
            } else
            {
                closeChildren();
            }
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
                // Force redraw of connections
                // HACK might be wrong?
                Parent.Invalidate();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            closeChildren();
        }

        private void closeChildren()
        {
            foreach(NodeControl child in childNodes)
            {
                child.closeChildren();
                child.Parent.Controls.Remove(child);
            }
            childNodes.Clear();
        }

        // Move the NodeControl so it's not overlapping any others
        public void findOpenSpace()
        {
            IEnumerable<NodeControl> otherControls = Parent.Controls.OfType<NodeControl>().Where(n => n != this);
            Point potentialLocation = new Point(this.Location.X, this.Location.Y);
            bool findingSpace = true;
            while (findingSpace)
            {
                bool noCollision = true;
                foreach(NodeControl node in otherControls)
                {
                    int xSpace = Math.Abs(potentialLocation.X - node.Location.X);
                    int ySpace = Math.Abs(potentialLocation.Y - node.Location.Y);
                    if(xSpace < NODE_WIDTH && ySpace < NODE_HEIGHT)
                    {
                        noCollision = false;
                        break;
                    }
                }
                if (noCollision)
                {
                    findingSpace = false;
                } else
                {
                    if(potentialLocation.X + NODE_WIDTH > Parent.Width)
                    {
                        potentialLocation.X = 0;
                        potentialLocation.Y += NODE_VERTICAL_SPACING;
                    } else
                    {
                        potentialLocation.X += NODE_HORIZONTAL_SPACING/2;
                    }
                }
            }
            Location = potentialLocation;
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Model model { get; set; }
        public Form1()
        {
            InitializeComponent();

            model = new Model();
            //HACK for checking things are shown correctly
            model.Variables.Add(new Variable("TargetIsDead", "The agent's target has been killed"));
            model.Variables.Add(new Variable("WeaponArmed", "The agent is holding their weapon"));
            model.Variables.Add(new Variable("WeaponLoaded", "The agent's weapon is loaded"));
            model.Actions.Add(new Action("Attack", "Attack Target"));
            model.Actions.Add(new Action("AttackWithWeapon", "Attack target with a weapon", true));
            model.Actions.Add(new Action("AttackMelee", "Attack target with fists", true));
            model.Actions.Add(new Action("Reload", "Reload Weapon", true));

            actionBindingSource.DataSource = model.Actions;
            variablesBindingSource.DataSource = model.Variables;
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle drawRect = new Rectangle(0, 0, panel1.Width, panel1.Height);

            using (Pen gridPen = new Pen(Color.Beige))
            {
                gridPen.Width = 2;
                using (Brush bgBrush = new SolidBrush(Color.Gray))
                {
                    g.FillRectangle(bgBrush, drawRect);
                    for (int x = 0; x < panel1.Width; x += 40)
                    {
                        g.DrawLine(gridPen, new Point(x, 0), new Point(x, panel1.Height));
                    }
                    for (int y = 0; y < panel1.Height; y += 40)
                    {
                        g.DrawLine(gridPen, new Point(0, y), new Point(panel1.Width, y));
                    }
                }
            }
        }

    }
}

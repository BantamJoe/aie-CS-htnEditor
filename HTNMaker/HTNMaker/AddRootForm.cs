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
    public partial class AddRootForm : Form
    {
        public List<Action> PossibleActions { get; }
        public Action ChosenAction;

        public AddRootForm(List<Action> actions)
        {
            InitializeComponent();
            PossibleActions = actions;
            actionBindingSource.DataSource = PossibleActions;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addRootButton_Click(object sender, EventArgs e)
        {
            ChosenAction = actionBindingSource.Current as Action;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

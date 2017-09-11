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
    public enum StatementTypes { Condition, Effect };
    public partial class NewStatementForm : Form
    {
        HTNEditorForm parent;
        public List<Variable> PossibleVariables { get; }

        public Statement CreatedStatement;
        public NewStatementForm(HTNEditorForm parent, List<Variable> variables, StatementTypes type)
        {
            InitializeComponent();
            this.parent = parent;
            this.PossibleVariables = variables;
            variableBindingSource.DataSource = PossibleVariables;
            switch(type)
            {
                case StatementTypes.Condition:
                    Text = "New Conditon";
                    break;
                case StatementTypes.Effect:
                    Text = "New Effect";
                    break;
                default:
                    break;

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CreateStatementButton_Click(object sender, EventArgs e)
        {
            CreatedStatement = new Statement(variableBindingSource.Current as Variable, ValueCB.Checked);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

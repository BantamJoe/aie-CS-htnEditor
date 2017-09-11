using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//TODO add checkboxes to make an action primitive/root, disabled if those are invalid choices
//TODO figure out read-only databinding
// TODO get grid to use variable names

namespace HTNMaker
{
    public partial class HTNEditorForm : Form
    {
        public Model model { get; set; }
        public HTNEditorForm()
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
            model.Actions[0].addCondition(model.Variables[0], false);
            model.Actions[1].addCondition(model.Variables[1], true);
            model.Actions[1].addCondition(model.Variables[2], true);
            model.Actions[3].addCondition(model.Variables[2], false);
            model.Actions[3].addEffect(model.Variables[2], true);
            model.Actions[0].addEffect(model.Variables[0], true);
            model.Actions[0].addChild(model.Actions[1]);
            model.Actions[0].addChild(model.Actions[2]);
            model.Actions[0].addChild(model.Actions[3]);

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

        private void conditionsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statementBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void actionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (actionBindingSource.Current != null)
            {
                Action action = actionBindingSource.Current as Action;
                conditionBindingSource.DataSource = action.Conditions;
                effectBindingSource.DataSource = action.Effects;
                childActionBindingSource.DataSource = action.Children;
                selectedNameTB.Enabled = true;
                selectedDescriptionTB.Enabled = true;
            } else
            {
                conditionBindingSource.DataSource = null;
                effectBindingSource.DataSource = null;
                childActionBindingSource.DataSource = null;
                selectedNameTB.Enabled = false;
                selectedDescriptionTB.Enabled = false;
            }
        }

        private void conditionsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectedNameTB_Validating(object sender, CancelEventArgs e)
        {
            if (actionBindingSource.Current != null)
            {
                Action selectedAction = actionBindingSource.Current as Action;
                string errorMsg;
                if (!IsValidActionName(selectedNameTB.Text, selectedAction, out errorMsg))
                {
                    actionBindingSource.CancelEdit();
                    e.Cancel = true;
                    selectedNameTB.SelectAll();
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void variableNameTB_Validating(object sender, CancelEventArgs e)
        {
            if (variablesBindingSource.Current != null)
            {
                Variable selectedVariable = variablesBindingSource.Current as Variable;
                string errorMsg;
                if (!IsValidVariableName(variableNameTB.Text, selectedVariable, out errorMsg))
                {
                    variablesBindingSource.CancelEdit();
                    e.Cancel = true;
                    variableNameTB.SelectAll();
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public bool IsValidActionName(string name, Action renamedAction, out string errorMsg)
        {
            //TODO validate action name (length, legal characters, whitespace)
            if (!IsUniqueActionName(name, renamedAction))
            {
                errorMsg = "Action must have unique name";
                return false;
            }
            errorMsg = "";
            return true;
        }

        public bool IsUniqueActionName(string name, Action renamedAction)
        {
            foreach (Action action in model.Actions)
            {
                if (action != renamedAction && action.Name == name)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsValidVariableName(string name, Variable renamedVariable, out string errorMsg)
        {
            //TODO other validation (length, legal characters, whitespace)
            if (!IsUniqueVariableName(name, renamedVariable))
            {
                errorMsg = "Variable must have unique name";
                return false;
            }
            errorMsg = "";
            return true;

        }

        public bool IsUniqueVariableName(string name, Variable renamedVariable)
        {
            foreach (Variable variable in model.Variables)
            {
                if (variable != renamedVariable && variable.Name == name)
                {
                    return false;
                }
            }
            return true;
        }

        private void PrimitiveActionCB_Validating(object sender, CancelEventArgs e)
        {
            if (actionBindingSource.Current != null)
            {
                Action selectedAction = actionBindingSource.Current as Action;
                // Cannot be checked if selected action has any children
                if (!selectedAction.HasNoChildren && PrimitiveActionCB.Checked)
                {
                    actionBindingSource.CancelEdit();
                    e.Cancel = true;
                    MessageBox.Show("Actions with children cannot be set as primitive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void CreateActionButton_Click(object sender, EventArgs e)
        {
            Action action = new Action(MakeUniqueActionName());
            actionBindingSource.Add(action);
        }

        public string MakeUniqueActionName()
        {
            string newNamePrefix = "NewAction";
            StringBuilder newName = new StringBuilder(newNamePrefix);
            string newNamePattern = "^(" + newNamePrefix + @")_\d+$"; // Prefix followed by underscore and one or more digits
            bool unnumberedOK = true;
            Regex newNameExpression = new Regex(newNamePattern);
            List<int> usedDigits = new List<int>();
            foreach (Action action in model.Actions)
            {
                if (action.Name == newNamePrefix)
                {
                    unnumberedOK = false;
                } else if (newNameExpression.Match(action.Name).Success)
                {
                    int suffix = int.Parse(action.Name.Split('_')[1]);
                    usedDigits.Add(suffix);
                }
            }
            if (!unnumberedOK)
            {
                newName.Append("_");
                newName.Append(findFirstNotInList(usedDigits).ToString());
            }
            return newName.ToString();
        }

        public string MakeUniqueVariableName()
        {
            string newNamePrefix = "NewVariable";
            StringBuilder newName = new StringBuilder(newNamePrefix);
            string newNamePattern = "^(" + newNamePrefix + @")_\d+$"; // Prefix followed by underscore and one or more digits
            bool unnumberedOK = true;
            Regex newNameExpression = new Regex(newNamePattern);
            List<int> usedDigits = new List<int>();
            foreach (Variable variable in model.Variables)
            {
                if (variable.Name == newNamePrefix)
                {
                    unnumberedOK = false;
                }
                else if (newNameExpression.Match(variable.Name).Success)
                {
                    int suffix = int.Parse(variable.Name.Split('_')[1]);
                    usedDigits.Add(suffix);
                }
            }
            if (!unnumberedOK)
            {
                newName.Append("_");
                newName.Append(findFirstNotInList(usedDigits).ToString());
            }
            return newName.ToString();
        }

        public int findFirstNotInList(List<int> list)
        {
            int firstAvailable = Enumerable.Range(1, int.MaxValue).Except(list).FirstOrDefault();
            return firstAvailable;
        }

        private void CreateVariableButton_Click(object sender, EventArgs e)
        {
            Variable newVariable = new Variable(MakeUniqueVariableName());
            variablesBindingSource.Add(newVariable);
        }

        private void DeleteActionButton_Click(object sender, EventArgs e)
        {
            if (actionBindingSource.Current != null)
            {
                Action selectedAction = actionBindingSource.Current as Action;
                DialogResult response = MessageBox.Show("Are you sure you want to delete " + selectedAction.Name, "Delete Action", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    // Remove selected action from all parents
                    foreach (Action action in model.Actions)
                    {
                        action.removeChild(selectedAction);
                    }
                    // Remove selected action from list
                    actionBindingSource.RemoveCurrent();
                }
            }
        }

        private void DeleteVariableButton_Click(object sender, EventArgs e)
        {
            if (variablesBindingSource.Current != null)
            {
                Variable selectedVariable = variablesBindingSource.Current as Variable;
                DialogResult response = MessageBox.Show("Are you sure you want to delete " + selectedVariable.Name, "Delete Variable", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    conditionsGridView.DataSource = null;
                    effectsGridView.DataSource = null;

                    // Remove variable from all actions
                    foreach (Action action in model.Actions)
                    {

                        action.removeCondition(selectedVariable);
                        action.removeEffect(selectedVariable);
                    }
                    // Remove from list
                    variablesBindingSource.RemoveCurrent();

                    conditionsGridView.DataSource = conditionBindingSource;
                    effectsGridView.DataSource = effectBindingSource;
                }
            }
        }

        private void AddConditionButton_Click(object sender, EventArgs e)
        {
            if (actionBindingSource.Current != null)
            {
                List<Variable> possibleVariables = new List<Variable>();
                Action selectedAction = actionBindingSource.Current as Action;
                possibleVariables.AddRange(model.Variables.Where(v => !selectedAction.Conditions.Any(c => c.Variable == v)));
                NewStatementForm conditionStatementForm = new NewStatementForm(this, possibleVariables, StatementTypes.Condition);
                conditionStatementForm.ShowDialog();
                if (conditionStatementForm.DialogResult == DialogResult.OK)
                {
                    conditionBindingSource.Add(conditionStatementForm.CreatedStatement);
                }
            }
        }

        private void AddEffectButton_Click(object sender, EventArgs e)
        {
            if (actionBindingSource.Current != null)
            {
                List<Variable> possibleVariables = new List<Variable>();
                Action selectedAction = actionBindingSource.Current as Action;
                possibleVariables.AddRange(model.Variables.Where(v => !selectedAction.Effects.Any(s => s.Variable == v)));
                NewStatementForm effectStatementForm = new NewStatementForm(this, possibleVariables, StatementTypes.Effect);
                effectStatementForm.ShowDialog();
                if (effectStatementForm.DialogResult == DialogResult.OK)
                {
                    effectBindingSource.Add(effectStatementForm.CreatedStatement);
                }
            }
        }

        private void RemoveConditionButton_Click(object sender, EventArgs e)
        {
            if (conditionBindingSource.Current != null)
            {
                conditionBindingSource.RemoveCurrent();
            }
        }

        private void RemoveEffectButton_Click(object sender, EventArgs e)
        {
            if (effectBindingSource.Current != null)
            {
                effectBindingSource.RemoveCurrent();
            }
        }


        private void RemoveChildButton_Click(object sender, EventArgs e)
        {
            if (childActionBindingSource.Current != null)
            {
                Action childAction = childActionBindingSource.Current as Action;
                Action parent = actionBindingSource.Current as Action;
                childActionBindingSource.DataSource = null;
                parent.removeChild(childAction);
                childActionBindingSource.DataSource = parent.Children;
            }
        }

        private void variablesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if(variablesBindingSource.Current != null)
            {
                variableNameTB.Enabled = true;
                variableDescriptionTB.Enabled = true;
            } else
            {
                variableNameTB.Enabled = false;
                variableDescriptionTB.Enabled = false;
            }
        }

        private void AddChildButton_Click(object sender, EventArgs e)
        {
            List<Action> possibleActions = new List<Action>();
            Action selectedAction = actionBindingSource.Current as Action;
            //
            possibleActions.AddRange(model.Actions.Where(a => (a != selectedAction) &&
                                                                !(a as Action).Descendants.Any(d => d == selectedAction) &&
                                                                !selectedAction.Descendants.Any(d => d == a)));
            if (possibleActions.Count != 0)
            {
                AddChildForm childForm = new AddChildForm(possibleActions);
                childForm.ShowDialog();
                if (childForm.DialogResult == DialogResult.OK)
                {
                    //TODO handle errors
                    selectedAction.addChild(childForm.ChosenAction);
                    childList.Refresh();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.ShowDialog();
            //TODO set save dialog options
            //TODO only save if "save" chosen
            Stream fs = saveDialog.OpenFile();
            model.Save(fs);
        }
    }
}

﻿using System;
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

            makeBlankHTN();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle drawRect = new Rectangle(0, 0, graphPanel.Width, graphPanel.Height);

            using (Pen gridPen = new Pen(Color.Beige))
            {
                //HACK try doublebuffering, or get rid of grid
                gridPen.Width = 2;
                using (Brush bgBrush = new SolidBrush(Color.Gray))
                {
                    g.FillRectangle(bgBrush, drawRect);
                    for (int x = 0; x < graphPanel.Width; x += 40)
                    {
                        g.DrawLine(gridPen, new Point(x, 0), new Point(x, graphPanel.Height));
                    }
                    for (int y = 0; y < graphPanel.Height; y += 40)
                    {
                        g.DrawLine(gridPen, new Point(0, y), new Point(graphPanel.Width, y));
                    }
                }
            }
            using (Pen connectionPen = new Pen(Color.Black, 2))
            {
                foreach(Control control in graphPanel.Controls)
                {
                    NodeControl node = control as NodeControl;
                    if(node != null)
                    {
                        //HACK maybe have tranparent panel above, draw onto that
                        node.PaintConnections(g, connectionPen);
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
                    model.TopLevelActions.Remove(selectedAction);
                    //TODO check for any nodecontrols with removed action
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
            if (!selectedAction.IsPrimitive)
            {
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
            } else
            {
                MessageBox.Show("Primitive actions cannot have children", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load();
        }

        private void makeBlankHTN()
        {
            model = new Model();
            bindDataSources();
            //TODO remove nodes from graph
        }

        private void save()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.CreatePrompt = true;
            saveDialog.Filter = "XML Files (*.xml)|*.xml";
            saveDialog.DefaultExt = "xml";
            DialogResult result = saveDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Stream fs = null;
                try
                {
                    fs = saveDialog.OpenFile();
                    if (fs != null)
                    {
                        using (fs)
                        {
                            model.Save(fs);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
        }

        private void load()
        {
            OpenFileDialog loadDialog = new OpenFileDialog();
            loadDialog.Filter = "xml files (*.xml)|*.xml";
            Stream fs = null;
            if (loadDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = loadDialog.OpenFile();
                    if (fs != null)
                    {
                        using (fs)
                        {
                            model.Load(fs);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                bindDataSources();
            }
            //TODO remove nodes from graph
        }

        private void bindDataSources()
        {
            actionBindingSource.DataSource = model.Actions;
            rootActionBindingSource.DataSource = model.TopLevelActions;
            variablesBindingSource.DataSource = model.Variables;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO prompt if not saved
            makeBlankHTN();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            //TODO prompt if not saved
            makeBlankHTN();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //TODO prompt if not saved
            load();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            save();
        }

        private void addRootActionButton_Click(object sender, EventArgs e)
        {
            //TODO create modal dialog which allows valid non-root action to be selected
        }

        private void removeRootActionButton_Click(object sender, EventArgs e)
        {
            rootActionBindingSource.RemoveCurrent();
        }

        private void actionListBox_MouseDown(object sender, MouseEventArgs e)
        {
            //HACK figure out how to allow selection by clicking but also drag and drop
            //DoDragDrop((actionBindingSource.Current as Action), DragDropEffects.Link);
        }

        private void graphPanel_DragDrop(object sender, DragEventArgs e)
        {
            //TODO create nodecontrol for a dropped action
            Action a = e.Data.GetData(typeof(Action)) as Action;
            if(a != null)
            {
                NodeControl node = new NodeControl(a);
                Controls.Add(node);
                Point clientPoint = this.PointToClient(new Point(e.X, e.Y));
                node.Location = clientPoint;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //HACK remove when drag and drop figured out
            if (actionBindingSource.Current != null)
            {
                NodeControl node = new NodeControl(actionBindingSource.Current as Action);
                graphPanel.Controls.Add(node);
                node.Location = new Point(200, 50);     //TODO find open space to place node
            }
        }

        private void graphPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            graphPanel.Invalidate();
        }

        private void graphPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            graphPanel.Invalidate();
        }
    }
}

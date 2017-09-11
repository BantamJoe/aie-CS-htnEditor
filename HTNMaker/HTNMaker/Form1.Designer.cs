namespace HTNMaker
{
    partial class HTNEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HTNEditorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.elementTabControl = new System.Windows.Forms.TabControl();
            this.actionTab = new System.Windows.Forms.TabPage();
            this.DeleteActionButton = new System.Windows.Forms.Button();
            this.CreateActionButton = new System.Windows.Forms.Button();
            this.actionListBox = new System.Windows.Forms.ListBox();
            this.variablesTab = new System.Windows.Forms.TabPage();
            this.DeleteVariableButton = new System.Windows.Forms.Button();
            this.CreateVariableButton = new System.Windows.Forms.Button();
            this.variablesList = new System.Windows.Forms.ListBox();
            this.variablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.editTabControl = new System.Windows.Forms.TabControl();
            this.ActionEditTab = new System.Windows.Forms.TabPage();
            this.RemoveChildButton = new System.Windows.Forms.Button();
            this.AddChildButton = new System.Windows.Forms.Button();
            this.RemoveEffectButton = new System.Windows.Forms.Button();
            this.AddEffectButton = new System.Windows.Forms.Button();
            this.RemoveConditionButton = new System.Windows.Forms.Button();
            this.AddConditionButton = new System.Windows.Forms.Button();
            this.PrimitiveActionCB = new System.Windows.Forms.CheckBox();
            this.effectsGridView = new System.Windows.Forms.DataGridView();
            this.variableDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.effectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conditionsGridView = new System.Windows.Forms.DataGridView();
            this.variableNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.conditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.childList = new System.Windows.Forms.ListBox();
            this.childActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.effectsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedDescriptionTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.variableEditTab = new System.Windows.Forms.TabPage();
            this.variableDescriptionTB = new System.Windows.Forms.TextBox();
            this.variableDescriptionLabel = new System.Windows.Forms.Label();
            this.variableNameTB = new System.Windows.Forms.TextBox();
            this.variableNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.elementTabControl.SuspendLayout();
            this.actionTab.SuspendLayout();
            this.variablesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variablesBindingSource)).BeginInit();
            this.editTabControl.SuspendLayout();
            this.ActionEditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childActionBindingSource)).BeginInit();
            this.variableEditTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.loadToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "New";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Save";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            // 
            // actionBindingSource
            // 
            this.actionBindingSource.DataSource = typeof(HTNMaker.Action);
            this.actionBindingSource.CurrentChanged += new System.EventHandler(this.actionBindingSource_CurrentChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1084, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // elementTabControl
            // 
            this.elementTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.elementTabControl.Controls.Add(this.actionTab);
            this.elementTabControl.Controls.Add(this.variablesTab);
            this.elementTabControl.Location = new System.Drawing.Point(0, 59);
            this.elementTabControl.Name = "elementTabControl";
            this.elementTabControl.SelectedIndex = 0;
            this.elementTabControl.Size = new System.Drawing.Size(200, 849);
            this.elementTabControl.TabIndex = 4;
            // 
            // actionTab
            // 
            this.actionTab.Controls.Add(this.DeleteActionButton);
            this.actionTab.Controls.Add(this.CreateActionButton);
            this.actionTab.Controls.Add(this.actionListBox);
            this.actionTab.Location = new System.Drawing.Point(4, 22);
            this.actionTab.Name = "actionTab";
            this.actionTab.Padding = new System.Windows.Forms.Padding(3);
            this.actionTab.Size = new System.Drawing.Size(192, 823);
            this.actionTab.TabIndex = 0;
            this.actionTab.Text = "Actions";
            this.actionTab.UseVisualStyleBackColor = true;
            // 
            // DeleteActionButton
            // 
            this.DeleteActionButton.Location = new System.Drawing.Point(98, 320);
            this.DeleteActionButton.Name = "DeleteActionButton";
            this.DeleteActionButton.Size = new System.Drawing.Size(75, 34);
            this.DeleteActionButton.TabIndex = 2;
            this.DeleteActionButton.Text = "Delete Action";
            this.DeleteActionButton.UseVisualStyleBackColor = true;
            this.DeleteActionButton.Click += new System.EventHandler(this.DeleteActionButton_Click);
            // 
            // CreateActionButton
            // 
            this.CreateActionButton.Location = new System.Drawing.Point(17, 320);
            this.CreateActionButton.Name = "CreateActionButton";
            this.CreateActionButton.Size = new System.Drawing.Size(75, 34);
            this.CreateActionButton.TabIndex = 1;
            this.CreateActionButton.Text = "Create Action";
            this.CreateActionButton.UseVisualStyleBackColor = true;
            this.CreateActionButton.Click += new System.EventHandler(this.CreateActionButton_Click);
            // 
            // actionListBox
            // 
            this.actionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionListBox.DataSource = this.actionBindingSource;
            this.actionListBox.DisplayMember = "Name";
            this.actionListBox.FormattingEnabled = true;
            this.actionListBox.Location = new System.Drawing.Point(0, 6);
            this.actionListBox.Name = "actionListBox";
            this.actionListBox.Size = new System.Drawing.Size(192, 290);
            this.actionListBox.TabIndex = 0;
            // 
            // variablesTab
            // 
            this.variablesTab.Controls.Add(this.DeleteVariableButton);
            this.variablesTab.Controls.Add(this.CreateVariableButton);
            this.variablesTab.Controls.Add(this.variablesList);
            this.variablesTab.Location = new System.Drawing.Point(4, 22);
            this.variablesTab.Name = "variablesTab";
            this.variablesTab.Padding = new System.Windows.Forms.Padding(3);
            this.variablesTab.Size = new System.Drawing.Size(192, 823);
            this.variablesTab.TabIndex = 1;
            this.variablesTab.Text = "Variables";
            this.variablesTab.UseVisualStyleBackColor = true;
            // 
            // DeleteVariableButton
            // 
            this.DeleteVariableButton.Location = new System.Drawing.Point(99, 307);
            this.DeleteVariableButton.Name = "DeleteVariableButton";
            this.DeleteVariableButton.Size = new System.Drawing.Size(75, 35);
            this.DeleteVariableButton.TabIndex = 2;
            this.DeleteVariableButton.Text = "Delete Variable";
            this.DeleteVariableButton.UseVisualStyleBackColor = true;
            this.DeleteVariableButton.Click += new System.EventHandler(this.DeleteVariableButton_Click);
            // 
            // CreateVariableButton
            // 
            this.CreateVariableButton.Location = new System.Drawing.Point(18, 307);
            this.CreateVariableButton.Name = "CreateVariableButton";
            this.CreateVariableButton.Size = new System.Drawing.Size(75, 35);
            this.CreateVariableButton.TabIndex = 1;
            this.CreateVariableButton.Text = "Create Variable";
            this.CreateVariableButton.UseVisualStyleBackColor = true;
            this.CreateVariableButton.Click += new System.EventHandler(this.CreateVariableButton_Click);
            // 
            // variablesList
            // 
            this.variablesList.DataSource = this.variablesBindingSource;
            this.variablesList.DisplayMember = "Name";
            this.variablesList.FormattingEnabled = true;
            this.variablesList.Location = new System.Drawing.Point(0, 7);
            this.variablesList.Name = "variablesList";
            this.variablesList.Size = new System.Drawing.Size(192, 251);
            this.variablesList.TabIndex = 0;
            this.variablesList.ValueMember = "Name";
            // 
            // variablesBindingSource
            // 
            this.variablesBindingSource.DataSource = typeof(HTNMaker.Variable);
            this.variablesBindingSource.CurrentChanged += new System.EventHandler(this.variablesBindingSource_CurrentChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(202, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 827);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // editTabControl
            // 
            this.editTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editTabControl.Controls.Add(this.ActionEditTab);
            this.editTabControl.Controls.Add(this.variableEditTab);
            this.editTabControl.Location = new System.Drawing.Point(776, 59);
            this.editTabControl.Name = "editTabControl";
            this.editTabControl.SelectedIndex = 0;
            this.editTabControl.Size = new System.Drawing.Size(308, 849);
            this.editTabControl.TabIndex = 6;
            // 
            // ActionEditTab
            // 
            this.ActionEditTab.AutoScroll = true;
            this.ActionEditTab.Controls.Add(this.RemoveChildButton);
            this.ActionEditTab.Controls.Add(this.AddChildButton);
            this.ActionEditTab.Controls.Add(this.RemoveEffectButton);
            this.ActionEditTab.Controls.Add(this.AddEffectButton);
            this.ActionEditTab.Controls.Add(this.RemoveConditionButton);
            this.ActionEditTab.Controls.Add(this.AddConditionButton);
            this.ActionEditTab.Controls.Add(this.PrimitiveActionCB);
            this.ActionEditTab.Controls.Add(this.effectsGridView);
            this.ActionEditTab.Controls.Add(this.conditionsGridView);
            this.ActionEditTab.Controls.Add(this.label4);
            this.ActionEditTab.Controls.Add(this.childList);
            this.ActionEditTab.Controls.Add(this.effectsLabel);
            this.ActionEditTab.Controls.Add(this.label3);
            this.ActionEditTab.Controls.Add(this.selectedDescriptionTB);
            this.ActionEditTab.Controls.Add(this.label2);
            this.ActionEditTab.Controls.Add(this.selectedNameTB);
            this.ActionEditTab.Controls.Add(this.label1);
            this.ActionEditTab.Location = new System.Drawing.Point(4, 22);
            this.ActionEditTab.Name = "ActionEditTab";
            this.ActionEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActionEditTab.Size = new System.Drawing.Size(300, 823);
            this.ActionEditTab.TabIndex = 0;
            this.ActionEditTab.Text = "Actions";
            this.ActionEditTab.UseVisualStyleBackColor = true;
            // 
            // RemoveChildButton
            // 
            this.RemoveChildButton.Location = new System.Drawing.Point(201, 700);
            this.RemoveChildButton.Name = "RemoveChildButton";
            this.RemoveChildButton.Size = new System.Drawing.Size(75, 38);
            this.RemoveChildButton.TabIndex = 30;
            this.RemoveChildButton.Text = "Remove Child";
            this.RemoveChildButton.UseVisualStyleBackColor = true;
            this.RemoveChildButton.Click += new System.EventHandler(this.RemoveChildButton_Click);
            // 
            // AddChildButton
            // 
            this.AddChildButton.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.actionBindingSource, "IsNotPrimitive", true));
            this.AddChildButton.Location = new System.Drawing.Point(120, 700);
            this.AddChildButton.Name = "AddChildButton";
            this.AddChildButton.Size = new System.Drawing.Size(75, 38);
            this.AddChildButton.TabIndex = 29;
            this.AddChildButton.Text = "Add Child";
            this.AddChildButton.UseVisualStyleBackColor = true;
            this.AddChildButton.Click += new System.EventHandler(this.AddChildButton_Click);
            // 
            // RemoveEffectButton
            // 
            this.RemoveEffectButton.Location = new System.Drawing.Point(195, 519);
            this.RemoveEffectButton.Name = "RemoveEffectButton";
            this.RemoveEffectButton.Size = new System.Drawing.Size(75, 38);
            this.RemoveEffectButton.TabIndex = 28;
            this.RemoveEffectButton.Text = "Remove Effect";
            this.RemoveEffectButton.UseVisualStyleBackColor = true;
            this.RemoveEffectButton.Click += new System.EventHandler(this.RemoveEffectButton_Click);
            // 
            // AddEffectButton
            // 
            this.AddEffectButton.Location = new System.Drawing.Point(112, 519);
            this.AddEffectButton.Name = "AddEffectButton";
            this.AddEffectButton.Size = new System.Drawing.Size(75, 38);
            this.AddEffectButton.TabIndex = 27;
            this.AddEffectButton.Text = "Add Effect";
            this.AddEffectButton.UseVisualStyleBackColor = true;
            this.AddEffectButton.Click += new System.EventHandler(this.AddEffectButton_Click);
            // 
            // RemoveConditionButton
            // 
            this.RemoveConditionButton.Location = new System.Drawing.Point(195, 334);
            this.RemoveConditionButton.Name = "RemoveConditionButton";
            this.RemoveConditionButton.Size = new System.Drawing.Size(75, 34);
            this.RemoveConditionButton.TabIndex = 26;
            this.RemoveConditionButton.Text = "Remove Condition";
            this.RemoveConditionButton.UseVisualStyleBackColor = true;
            this.RemoveConditionButton.Click += new System.EventHandler(this.RemoveConditionButton_Click);
            // 
            // AddConditionButton
            // 
            this.AddConditionButton.Location = new System.Drawing.Point(112, 334);
            this.AddConditionButton.Name = "AddConditionButton";
            this.AddConditionButton.Size = new System.Drawing.Size(77, 34);
            this.AddConditionButton.TabIndex = 25;
            this.AddConditionButton.Text = "Add Condition";
            this.AddConditionButton.UseVisualStyleBackColor = true;
            this.AddConditionButton.Click += new System.EventHandler(this.AddConditionButton_Click);
            // 
            // PrimitiveActionCB
            // 
            this.PrimitiveActionCB.AutoSize = true;
            this.PrimitiveActionCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrimitiveActionCB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.actionBindingSource, "IsPrimitive", true));
            this.PrimitiveActionCB.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.actionBindingSource, "HasNoChildren", true));
            this.PrimitiveActionCB.Location = new System.Drawing.Point(30, 143);
            this.PrimitiveActionCB.Name = "PrimitiveActionCB";
            this.PrimitiveActionCB.Size = new System.Drawing.Size(98, 17);
            this.PrimitiveActionCB.TabIndex = 24;
            this.PrimitiveActionCB.Text = "Primitive Action";
            this.PrimitiveActionCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrimitiveActionCB.UseVisualStyleBackColor = true;
            this.PrimitiveActionCB.Validating += new System.ComponentModel.CancelEventHandler(this.PrimitiveActionCB_Validating);
            // 
            // effectsGridView
            // 
            this.effectsGridView.AllowUserToAddRows = false;
            this.effectsGridView.AllowUserToDeleteRows = false;
            this.effectsGridView.AutoGenerateColumns = false;
            this.effectsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.effectsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.effectsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.variableDataGridViewTextBoxColumn1,
            this.valueDataGridViewCheckBoxColumn1});
            this.effectsGridView.DataSource = this.effectBindingSource;
            this.effectsGridView.Location = new System.Drawing.Point(112, 384);
            this.effectsGridView.Name = "effectsGridView";
            this.effectsGridView.Size = new System.Drawing.Size(173, 111);
            this.effectsGridView.TabIndex = 21;
            // 
            // variableDataGridViewTextBoxColumn1
            // 
            this.variableDataGridViewTextBoxColumn1.DataPropertyName = "VariableName";
            this.variableDataGridViewTextBoxColumn1.HeaderText = "Variable";
            this.variableDataGridViewTextBoxColumn1.Name = "variableDataGridViewTextBoxColumn1";
            this.variableDataGridViewTextBoxColumn1.ReadOnly = true;
            this.variableDataGridViewTextBoxColumn1.Width = 70;
            // 
            // valueDataGridViewCheckBoxColumn1
            // 
            this.valueDataGridViewCheckBoxColumn1.DataPropertyName = "Value";
            this.valueDataGridViewCheckBoxColumn1.HeaderText = "Value";
            this.valueDataGridViewCheckBoxColumn1.Name = "valueDataGridViewCheckBoxColumn1";
            this.valueDataGridViewCheckBoxColumn1.Width = 40;
            // 
            // effectBindingSource
            // 
            this.effectBindingSource.DataSource = typeof(HTNMaker.Statement);
            // 
            // conditionsGridView
            // 
            this.conditionsGridView.AllowUserToAddRows = false;
            this.conditionsGridView.AllowUserToDeleteRows = false;
            this.conditionsGridView.AutoGenerateColumns = false;
            this.conditionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.conditionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conditionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.variableNameDataGridViewTextBoxColumn,
            this.valueDataGridViewCheckBoxColumn});
            this.conditionsGridView.DataSource = this.conditionBindingSource;
            this.conditionsGridView.Location = new System.Drawing.Point(112, 205);
            this.conditionsGridView.Name = "conditionsGridView";
            this.conditionsGridView.Size = new System.Drawing.Size(173, 113);
            this.conditionsGridView.TabIndex = 20;
            this.conditionsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.conditionsGridView_CellContentClick);
            // 
            // variableNameDataGridViewTextBoxColumn
            // 
            this.variableNameDataGridViewTextBoxColumn.DataPropertyName = "VariableName";
            this.variableNameDataGridViewTextBoxColumn.HeaderText = "Variable";
            this.variableNameDataGridViewTextBoxColumn.Name = "variableNameDataGridViewTextBoxColumn";
            this.variableNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.variableNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // valueDataGridViewCheckBoxColumn
            // 
            this.valueDataGridViewCheckBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewCheckBoxColumn.HeaderText = "Value";
            this.valueDataGridViewCheckBoxColumn.Name = "valueDataGridViewCheckBoxColumn";
            this.valueDataGridViewCheckBoxColumn.Width = 40;
            // 
            // conditionBindingSource
            // 
            this.conditionBindingSource.DataMember = "Conditions";
            this.conditionBindingSource.DataSource = this.actionBindingSource;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Child Actions";
            // 
            // childList
            // 
            this.childList.DataSource = this.childActionBindingSource;
            this.childList.DisplayMember = "Name";
            this.childList.FormattingEnabled = true;
            this.childList.Location = new System.Drawing.Point(120, 582);
            this.childList.Name = "childList";
            this.childList.Size = new System.Drawing.Size(120, 95);
            this.childList.TabIndex = 18;
            // 
            // childActionBindingSource
            // 
            this.childActionBindingSource.DataSource = typeof(HTNMaker.Action);
            // 
            // effectsLabel
            // 
            this.effectsLabel.AutoSize = true;
            this.effectsLabel.Location = new System.Drawing.Point(64, 384);
            this.effectsLabel.Name = "effectsLabel";
            this.effectsLabel.Size = new System.Drawing.Size(40, 13);
            this.effectsLabel.TabIndex = 17;
            this.effectsLabel.Text = "Effects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Preconditions";
            // 
            // selectedDescriptionTB
            // 
            this.selectedDescriptionTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actionBindingSource, "Description", true));
            this.selectedDescriptionTB.Location = new System.Drawing.Point(112, 60);
            this.selectedDescriptionTB.Multiline = true;
            this.selectedDescriptionTB.Name = "selectedDescriptionTB";
            this.selectedDescriptionTB.Size = new System.Drawing.Size(129, 59);
            this.selectedDescriptionTB.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // selectedNameTB
            // 
            this.selectedNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actionBindingSource, "Name", true));
            this.selectedNameTB.Location = new System.Drawing.Point(112, 25);
            this.selectedNameTB.Name = "selectedNameTB";
            this.selectedNameTB.Size = new System.Drawing.Size(129, 20);
            this.selectedNameTB.TabIndex = 11;
            this.selectedNameTB.Validating += new System.ComponentModel.CancelEventHandler(this.selectedNameTB_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // variableEditTab
            // 
            this.variableEditTab.AutoScroll = true;
            this.variableEditTab.Controls.Add(this.variableDescriptionTB);
            this.variableEditTab.Controls.Add(this.variableDescriptionLabel);
            this.variableEditTab.Controls.Add(this.variableNameTB);
            this.variableEditTab.Controls.Add(this.variableNameLabel);
            this.variableEditTab.Location = new System.Drawing.Point(4, 22);
            this.variableEditTab.Name = "variableEditTab";
            this.variableEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.variableEditTab.Size = new System.Drawing.Size(300, 823);
            this.variableEditTab.TabIndex = 1;
            this.variableEditTab.Text = "Variables";
            this.variableEditTab.UseVisualStyleBackColor = true;
            // 
            // variableDescriptionTB
            // 
            this.variableDescriptionTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.variablesBindingSource, "Description", true));
            this.variableDescriptionTB.Location = new System.Drawing.Point(96, 69);
            this.variableDescriptionTB.Multiline = true;
            this.variableDescriptionTB.Name = "variableDescriptionTB";
            this.variableDescriptionTB.Size = new System.Drawing.Size(154, 83);
            this.variableDescriptionTB.TabIndex = 3;
            // 
            // variableDescriptionLabel
            // 
            this.variableDescriptionLabel.AutoSize = true;
            this.variableDescriptionLabel.Location = new System.Drawing.Point(16, 72);
            this.variableDescriptionLabel.Name = "variableDescriptionLabel";
            this.variableDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.variableDescriptionLabel.TabIndex = 2;
            this.variableDescriptionLabel.Text = "Description";
            // 
            // variableNameTB
            // 
            this.variableNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.variablesBindingSource, "Name", true));
            this.variableNameTB.Location = new System.Drawing.Point(96, 23);
            this.variableNameTB.Name = "variableNameTB";
            this.variableNameTB.Size = new System.Drawing.Size(154, 20);
            this.variableNameTB.TabIndex = 1;
            this.variableNameTB.Validating += new System.ComponentModel.CancelEventHandler(this.variableNameTB_Validating);
            // 
            // variableNameLabel
            // 
            this.variableNameLabel.AutoSize = true;
            this.variableNameLabel.Location = new System.Drawing.Point(16, 23);
            this.variableNameLabel.Name = "variableNameLabel";
            this.variableNameLabel.Size = new System.Drawing.Size(35, 13);
            this.variableNameLabel.TabIndex = 0;
            this.variableNameLabel.Text = "Name";
            // 
            // HTNEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 910);
            this.Controls.Add(this.editTabControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.elementTabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HTNEditorForm";
            this.Text = "HTN Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.elementTabControl.ResumeLayout(false);
            this.actionTab.ResumeLayout(false);
            this.variablesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.variablesBindingSource)).EndInit();
            this.editTabControl.ResumeLayout(false);
            this.ActionEditTab.ResumeLayout(false);
            this.ActionEditTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childActionBindingSource)).EndInit();
            this.variableEditTab.ResumeLayout(false);
            this.variableEditTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabControl elementTabControl;
        private System.Windows.Forms.TabPage actionTab;
        private System.Windows.Forms.TabPage variablesTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox actionListBox;
        private System.Windows.Forms.ListBox variablesList;
        private System.Windows.Forms.BindingSource variablesBindingSource;
        private System.Windows.Forms.BindingSource actionBindingSource;
        private System.Windows.Forms.TabControl editTabControl;
        private System.Windows.Forms.TabPage ActionEditTab;
        private System.Windows.Forms.TabPage variableEditTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox childList;
        private System.Windows.Forms.Label effectsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selectedDescriptionTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selectedNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox variableDescriptionTB;
        private System.Windows.Forms.Label variableDescriptionLabel;
        private System.Windows.Forms.TextBox variableNameTB;
        private System.Windows.Forms.Label variableNameLabel;
        private System.Windows.Forms.DataGridView effectsGridView;
        private System.Windows.Forms.BindingSource effectBindingSource;
        private System.Windows.Forms.DataGridView conditionsGridView;
        private System.Windows.Forms.BindingSource childActionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn variableDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valueDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.CheckBox PrimitiveActionCB;
        private System.Windows.Forms.Button DeleteActionButton;
        private System.Windows.Forms.Button CreateActionButton;
        private System.Windows.Forms.Button RemoveChildButton;
        private System.Windows.Forms.Button AddChildButton;
        private System.Windows.Forms.Button RemoveEffectButton;
        private System.Windows.Forms.Button AddEffectButton;
        private System.Windows.Forms.Button RemoveConditionButton;
        private System.Windows.Forms.Button AddConditionButton;
        private System.Windows.Forms.Button DeleteVariableButton;
        private System.Windows.Forms.Button CreateVariableButton;
        private System.Windows.Forms.BindingSource conditionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn variableNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valueDataGridViewCheckBoxColumn;
    }
}


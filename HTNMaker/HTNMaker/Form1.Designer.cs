namespace HTNMaker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.elementTabControl = new System.Windows.Forms.TabControl();
            this.actionTab = new System.Windows.Forms.TabPage();
            this.actionListBox = new System.Windows.Forms.ListBox();
            this.variablesTab = new System.Windows.Forms.TabPage();
            this.variablesList = new System.Windows.Forms.ListBox();
            this.variablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.actionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.elementTabControl.SuspendLayout();
            this.actionTab.SuspendLayout();
            this.variablesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).BeginInit();
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(800, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 511);
            this.panel2.TabIndex = 2;
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
            this.elementTabControl.Size = new System.Drawing.Size(200, 511);
            this.elementTabControl.TabIndex = 4;
            // 
            // actionTab
            // 
            this.actionTab.Controls.Add(this.actionListBox);
            this.actionTab.Location = new System.Drawing.Point(4, 22);
            this.actionTab.Name = "actionTab";
            this.actionTab.Padding = new System.Windows.Forms.Padding(3);
            this.actionTab.Size = new System.Drawing.Size(192, 485);
            this.actionTab.TabIndex = 0;
            this.actionTab.Text = "Actions";
            this.actionTab.UseVisualStyleBackColor = true;
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
            this.variablesTab.Controls.Add(this.variablesList);
            this.variablesTab.Location = new System.Drawing.Point(4, 22);
            this.variablesTab.Name = "variablesTab";
            this.variablesTab.Padding = new System.Windows.Forms.Padding(3);
            this.variablesTab.Size = new System.Drawing.Size(192, 485);
            this.variablesTab.TabIndex = 1;
            this.variablesTab.Text = "Variables";
            this.variablesTab.UseVisualStyleBackColor = true;
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
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(206, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 511);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // actionBindingSource
            // 
            this.actionBindingSource.DataSource = typeof(HTNMaker.Action);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.elementTabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.elementTabControl.ResumeLayout(false);
            this.actionTab.ResumeLayout(false);
            this.variablesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.variablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
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
    }
}


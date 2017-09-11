namespace HTNMaker
{
    partial class NewStatementForm
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
            this.VariableComboBox = new System.Windows.Forms.ComboBox();
            this.variableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ValueCB = new System.Windows.Forms.CheckBox();
            this.CreateStatementButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VariableComboBox
            // 
            this.VariableComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VariableComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VariableComboBox.DataSource = this.variableBindingSource;
            this.VariableComboBox.DisplayMember = "Name";
            this.VariableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VariableComboBox.FormattingEnabled = true;
            this.VariableComboBox.Location = new System.Drawing.Point(124, 48);
            this.VariableComboBox.Name = "VariableComboBox";
            this.VariableComboBox.Size = new System.Drawing.Size(121, 21);
            this.VariableComboBox.TabIndex = 0;
            // 
            // variableBindingSource
            // 
            this.variableBindingSource.DataSource = typeof(HTNMaker.Variable);
            // 
            // ValueCB
            // 
            this.ValueCB.AutoSize = true;
            this.ValueCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ValueCB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ValueCB.Location = new System.Drawing.Point(88, 87);
            this.ValueCB.Name = "ValueCB";
            this.ValueCB.Size = new System.Drawing.Size(54, 17);
            this.ValueCB.TabIndex = 1;
            this.ValueCB.Text = "True?";
            this.ValueCB.UseVisualStyleBackColor = true;
            // 
            // CreateStatementButton
            // 
            this.CreateStatementButton.Location = new System.Drawing.Point(66, 176);
            this.CreateStatementButton.Name = "CreateStatementButton";
            this.CreateStatementButton.Size = new System.Drawing.Size(75, 23);
            this.CreateStatementButton.TabIndex = 2;
            this.CreateStatementButton.Text = "Create";
            this.CreateStatementButton.UseVisualStyleBackColor = true;
            this.CreateStatementButton.Click += new System.EventHandler(this.CreateStatementButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(170, 176);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Variable";
            // 
            // NewStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateStatementButton);
            this.Controls.Add(this.ValueCB);
            this.Controls.Add(this.VariableComboBox);
            this.Name = "NewStatementForm";
            this.Text = "NewStatementForm";
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VariableComboBox;
        private System.Windows.Forms.CheckBox ValueCB;
        private System.Windows.Forms.Button CreateStatementButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource variableBindingSource;
    }
}
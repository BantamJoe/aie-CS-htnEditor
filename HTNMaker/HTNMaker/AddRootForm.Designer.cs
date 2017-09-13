namespace HTNMaker
{
    partial class AddRootForm
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
            this.addRootButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.actionCB = new System.Windows.Forms.ComboBox();
            this.actionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addRootButton
            // 
            this.addRootButton.Location = new System.Drawing.Point(39, 109);
            this.addRootButton.Name = "addRootButton";
            this.addRootButton.Size = new System.Drawing.Size(75, 23);
            this.addRootButton.TabIndex = 0;
            this.addRootButton.Text = "Add Action";
            this.addRootButton.UseVisualStyleBackColor = true;
            this.addRootButton.Click += new System.EventHandler(this.addRootButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(140, 109);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Action";
            // 
            // actionCB
            // 
            this.actionCB.DataSource = this.actionBindingSource;
            this.actionCB.DisplayMember = "Name";
            this.actionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionCB.FormattingEnabled = true;
            this.actionCB.Location = new System.Drawing.Point(103, 45);
            this.actionCB.Name = "actionCB";
            this.actionCB.Size = new System.Drawing.Size(121, 21);
            this.actionCB.TabIndex = 3;
            // 
            // actionBindingSource
            // 
            this.actionBindingSource.DataSource = typeof(HTNMaker.Action);
            // 
            // AddRootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 173);
            this.Controls.Add(this.actionCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addRootButton);
            this.Name = "AddRootForm";
            this.Text = "AddRootForm";
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRootButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox actionCB;
        private System.Windows.Forms.BindingSource actionBindingSource;
    }
}
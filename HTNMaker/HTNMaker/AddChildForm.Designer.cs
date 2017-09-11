namespace HTNMaker
{
    partial class AddChildForm
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
            this.ChildActionCB = new System.Windows.Forms.ComboBox();
            this.actionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddChildButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChildActionCB
            // 
            this.ChildActionCB.DataSource = this.actionBindingSource;
            this.ChildActionCB.DisplayMember = "Name";
            this.ChildActionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChildActionCB.FormattingEnabled = true;
            this.ChildActionCB.Location = new System.Drawing.Point(92, 49);
            this.ChildActionCB.Name = "ChildActionCB";
            this.ChildActionCB.Size = new System.Drawing.Size(121, 21);
            this.ChildActionCB.TabIndex = 0;
            // 
            // actionBindingSource
            // 
            this.actionBindingSource.DataSource = typeof(HTNMaker.Action);
            // 
            // AddChildButton
            // 
            this.AddChildButton.Location = new System.Drawing.Point(46, 110);
            this.AddChildButton.Name = "AddChildButton";
            this.AddChildButton.Size = new System.Drawing.Size(75, 23);
            this.AddChildButton.TabIndex = 1;
            this.AddChildButton.Text = "Add Child";
            this.AddChildButton.UseVisualStyleBackColor = true;
            this.AddChildButton.Click += new System.EventHandler(this.AddChildButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(138, 110);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.MouseCaptureChanged += new System.EventHandler(this.CancelButton_MouseCaptureChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Child Action";
            // 
            // AddChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddChildButton);
            this.Controls.Add(this.ChildActionCB);
            this.Name = "AddChildForm";
            this.Text = "Add Child";
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChildActionCB;
        private System.Windows.Forms.Button AddChildButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource actionBindingSource;
    }
}
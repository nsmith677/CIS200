namespace LibraryItems
{
    partial class EditBook
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
            this.selectBookLabel = new System.Windows.Forms.Label();
            this.selectBookComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectBookLabel
            // 
            this.selectBookLabel.AutoSize = true;
            this.selectBookLabel.Location = new System.Drawing.Point(122, 40);
            this.selectBookLabel.Name = "selectBookLabel";
            this.selectBookLabel.Size = new System.Drawing.Size(186, 17);
            this.selectBookLabel.TabIndex = 0;
            this.selectBookLabel.Text = "Please select a book to edit:";
            // 
            // selectBookComboBox
            // 
            this.selectBookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBookComboBox.FormattingEnabled = true;
            this.selectBookComboBox.Location = new System.Drawing.Point(78, 75);
            this.selectBookComboBox.Name = "selectBookComboBox";
            this.selectBookComboBox.Size = new System.Drawing.Size(273, 24);
            this.selectBookComboBox.TabIndex = 1;
            this.selectBookComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.selectBookComboBox_Validating);
            this.selectBookComboBox.Validated += new System.EventHandler(this.selectBookComboBox_Validated);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(241, 140);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 42);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(78, 140);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(110, 42);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditBook
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 251);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectBookComboBox);
            this.Controls.Add(this.selectBookLabel);
            this.Name = "EditBook";
            this.Text = "EditBook";
            this.Load += new System.EventHandler(this.EditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectBookLabel;
        private System.Windows.Forms.ComboBox selectBookComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
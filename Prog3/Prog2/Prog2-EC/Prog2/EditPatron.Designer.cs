namespace LibraryItems
{
    partial class editPatronForm
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
            this.selectPatronLabel = new System.Windows.Forms.Label();
            this.selectPatronComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectPatronLabel
            // 
            this.selectPatronLabel.AutoSize = true;
            this.selectPatronLabel.Location = new System.Drawing.Point(95, 41);
            this.selectPatronLabel.Name = "selectPatronLabel";
            this.selectPatronLabel.Size = new System.Drawing.Size(196, 17);
            this.selectPatronLabel.TabIndex = 0;
            this.selectPatronLabel.Text = "Please select a patron to edit:";
            this.selectPatronLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectPatronComboBox
            // 
            this.selectPatronComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPatronComboBox.FormattingEnabled = true;
            this.selectPatronComboBox.Location = new System.Drawing.Point(82, 73);
            this.selectPatronComboBox.Name = "selectPatronComboBox";
            this.selectPatronComboBox.Size = new System.Drawing.Size(234, 24);
            this.selectPatronComboBox.TabIndex = 1;
            this.selectPatronComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.SelectPatronComboBox_Validating);
            this.selectPatronComboBox.Validated += new System.EventHandler(this.SelectPatronComboBox_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(98, 122);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(72, 30);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(229, 122);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 30);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // editPatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 177);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.selectPatronComboBox);
            this.Controls.Add(this.selectPatronLabel);
            this.Name = "editPatronForm";
            this.Text = "Edit Patron";
            this.Load += new System.EventHandler(this.EditPatronForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectPatronLabel;
        private System.Windows.Forms.ComboBox selectPatronComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
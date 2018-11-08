namespace LibraryItems
{
    partial class CheckOutForm
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
            this.selectItemLabel = new System.Windows.Forms.Label();
            this.selectPatronLabel = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.patronComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectItemLabel
            // 
            this.selectItemLabel.AutoSize = true;
            this.selectItemLabel.Location = new System.Drawing.Point(55, 56);
            this.selectItemLabel.Name = "selectItemLabel";
            this.selectItemLabel.Size = new System.Drawing.Size(81, 17);
            this.selectItemLabel.TabIndex = 0;
            this.selectItemLabel.Text = "Select Item:";
            // 
            // selectPatronLabel
            // 
            this.selectPatronLabel.AutoSize = true;
            this.selectPatronLabel.Location = new System.Drawing.Point(55, 171);
            this.selectPatronLabel.Name = "selectPatronLabel";
            this.selectPatronLabel.Size = new System.Drawing.Size(97, 17);
            this.selectPatronLabel.TabIndex = 1;
            this.selectPatronLabel.Text = "Select Patron:";
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(58, 76);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(304, 24);
            this.itemComboBox.TabIndex = 2;
            this.itemComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.itemComboBox_Validating);
            this.itemComboBox.Validated += new System.EventHandler(this.itemComboBox_Validated);
            // 
            // patronComboBox
            // 
            this.patronComboBox.FormattingEnabled = true;
            this.patronComboBox.Location = new System.Drawing.Point(58, 191);
            this.patronComboBox.Name = "patronComboBox";
            this.patronComboBox.Size = new System.Drawing.Size(304, 24);
            this.patronComboBox.TabIndex = 3;
            this.patronComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronComboBox_Validating);
            this.patronComboBox.Validated += new System.EventHandler(this.patronComboBox_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(77, 261);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(254, 261);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 322);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.patronComboBox);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.selectPatronLabel);
            this.Controls.Add(this.selectItemLabel);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectItemLabel;
        private System.Windows.Forms.Label selectPatronLabel;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.ComboBox patronComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
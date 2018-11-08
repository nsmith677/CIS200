namespace LibraryItems
{
    partial class BookForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.loanPeriodLabel = new System.Windows.Forms.Label();
            this.callNumLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.publisherTxtBox = new System.Windows.Forms.TextBox();
            this.copyrightTxtBox = new System.Windows.Forms.TextBox();
            this.loanPeriodTxtBox = new System.Windows.Forms.TextBox();
            this.callNumberTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(75, 63);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(43, 95);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(71, 17);
            this.publisherLabel.TabIndex = 1;
            this.publisherLabel.Text = "Publisher:";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(42, 129);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(72, 17);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright:";
            // 
            // loanPeriodLabel
            // 
            this.loanPeriodLabel.AutoSize = true;
            this.loanPeriodLabel.Location = new System.Drawing.Point(25, 163);
            this.loanPeriodLabel.Name = "loanPeriodLabel";
            this.loanPeriodLabel.Size = new System.Drawing.Size(89, 17);
            this.loanPeriodLabel.TabIndex = 3;
            this.loanPeriodLabel.Text = "Loan Period:";
            // 
            // callNumLabel
            // 
            this.callNumLabel.AutoSize = true;
            this.callNumLabel.Location = new System.Drawing.Point(25, 201);
            this.callNumLabel.Name = "callNumLabel";
            this.callNumLabel.Size = new System.Drawing.Size(89, 17);
            this.callNumLabel.TabIndex = 4;
            this.callNumLabel.Text = "Call Number:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(60, 232);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(54, 17);
            this.authorLabel.TabIndex = 5;
            this.authorLabel.Text = "Author:";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(120, 58);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(100, 22);
            this.titleTxtBox.TabIndex = 6;
            this.titleTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.titleTxtBox_Validating);
            this.titleTxtBox.Validated += new System.EventHandler(this.titleTxtBox_Validated);
            // 
            // publisherTxtBox
            // 
            this.publisherTxtBox.Location = new System.Drawing.Point(120, 90);
            this.publisherTxtBox.Name = "publisherTxtBox";
            this.publisherTxtBox.Size = new System.Drawing.Size(100, 22);
            this.publisherTxtBox.TabIndex = 7;
            this.publisherTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.publisherTxtBox_Validating);
            this.publisherTxtBox.Validated += new System.EventHandler(this.publisherTxtBox_Validated);
            // 
            // copyrightTxtBox
            // 
            this.copyrightTxtBox.Location = new System.Drawing.Point(120, 124);
            this.copyrightTxtBox.Name = "copyrightTxtBox";
            this.copyrightTxtBox.Size = new System.Drawing.Size(100, 22);
            this.copyrightTxtBox.TabIndex = 8;
            this.copyrightTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.copyrightTxtBox_Validating);
            this.copyrightTxtBox.Validated += new System.EventHandler(this.copyrightTxtBox_Validated);
            // 
            // loanPeriodTxtBox
            // 
            this.loanPeriodTxtBox.Location = new System.Drawing.Point(120, 160);
            this.loanPeriodTxtBox.Name = "loanPeriodTxtBox";
            this.loanPeriodTxtBox.Size = new System.Drawing.Size(100, 22);
            this.loanPeriodTxtBox.TabIndex = 9;
            this.loanPeriodTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.loanPeriodTxtBox_Validating);
            this.loanPeriodTxtBox.Validated += new System.EventHandler(this.loanPeriodTxtBox_Validated);
            // 
            // callNumberTxtBox
            // 
            this.callNumberTxtBox.Location = new System.Drawing.Point(120, 196);
            this.callNumberTxtBox.Name = "callNumberTxtBox";
            this.callNumberTxtBox.Size = new System.Drawing.Size(100, 22);
            this.callNumberTxtBox.TabIndex = 10;
            this.callNumberTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.callNumberTxtBox_Validating);
            this.callNumberTxtBox.Validated += new System.EventHandler(this.callNumberTxtBox_Validated);
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(120, 227);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(100, 22);
            this.authorTxtBox.TabIndex = 11;
            this.authorTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.authorTxtBox_Validating);
            this.authorTxtBox.Validated += new System.EventHandler(this.authorTxtBox_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(39, 301);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(169, 301);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 371);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.callNumberTxtBox);
            this.Controls.Add(this.loanPeriodTxtBox);
            this.Controls.Add(this.copyrightTxtBox);
            this.Controls.Add(this.publisherTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.callNumLabel);
            this.Controls.Add(this.loanPeriodLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label loanPeriodLabel;
        private System.Windows.Forms.Label callNumLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.TextBox publisherTxtBox;
        private System.Windows.Forms.TextBox copyrightTxtBox;
        private System.Windows.Forms.TextBox loanPeriodTxtBox;
        private System.Windows.Forms.TextBox callNumberTxtBox;
        private System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
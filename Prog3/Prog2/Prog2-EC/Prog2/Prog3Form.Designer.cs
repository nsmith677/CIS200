﻿namespace LibraryItems
{
    partial class Prog3Form
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
            this.libraryMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedOutItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportTxt = new System.Windows.Forms.TextBox();
            this.libraryMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryMenuStrip
            // 
            this.libraryMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.libraryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.editToolStripMenuItem});
            this.libraryMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.libraryMenuStrip.Name = "libraryMenuStrip";
            this.libraryMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.libraryMenuStrip.Size = new System.Drawing.Size(779, 28);
            this.libraryMenuStrip.TabIndex = 0;
            this.libraryMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.openLibraryToolStripMenuItem,
            this.saveLibraryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openLibraryToolStripMenuItem
            // 
            this.openLibraryToolStripMenuItem.Name = "openLibraryToolStripMenuItem";
            this.openLibraryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.openLibraryToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.openLibraryToolStripMenuItem.Text = "Open Library";
            this.openLibraryToolStripMenuItem.Click += new System.EventHandler(this.openLibraryToolStripMenuItem_Click);
            // 
            // saveLibraryToolStripMenuItem
            // 
            this.saveLibraryToolStripMenuItem.Name = "saveLibraryToolStripMenuItem";
            this.saveLibraryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveLibraryToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.saveLibraryToolStripMenuItem.Text = "Save Library";
            this.saveLibraryToolStripMenuItem.Click += new System.EventHandler(this.saveLibraryToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patronToolStripMenuItem,
            this.bookToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.insertToolStripMenuItem.Text = "&Insert";
            // 
            // patronToolStripMenuItem
            // 
            this.patronToolStripMenuItem.Name = "patronToolStripMenuItem";
            this.patronToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.patronToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.patronToolStripMenuItem.Text = "&Patron";
            this.patronToolStripMenuItem.Click += new System.EventHandler(this.patronToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.bookToolStripMenuItem.Text = "&Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkOutToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.itemToolStripMenuItem.Text = "I&tem";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.checkOutToolStripMenuItem.Text = "&Check Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.returnToolStripMenuItem.Text = "&Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patronListToolStripMenuItem,
            this.itemListToolStripMenuItem,
            this.checkedOutItemsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // patronListToolStripMenuItem
            // 
            this.patronListToolStripMenuItem.Name = "patronListToolStripMenuItem";
            this.patronListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.patronListToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.patronListToolStripMenuItem.Text = "&Patron List";
            this.patronListToolStripMenuItem.Click += new System.EventHandler(this.patronListToolStripMenuItem_Click);
            // 
            // itemListToolStripMenuItem
            // 
            this.itemListToolStripMenuItem.Name = "itemListToolStripMenuItem";
            this.itemListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.itemListToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.itemListToolStripMenuItem.Text = "&Item List";
            this.itemListToolStripMenuItem.Click += new System.EventHandler(this.itemListToolStripMenuItem_Click);
            // 
            // checkedOutItemsToolStripMenuItem
            // 
            this.checkedOutItemsToolStripMenuItem.Name = "checkedOutItemsToolStripMenuItem";
            this.checkedOutItemsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.checkedOutItemsToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.checkedOutItemsToolStripMenuItem.Text = "&Checked Out Items";
            this.checkedOutItemsToolStripMenuItem.Click += new System.EventHandler(this.checkedOutItemsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patronToolStripMenuItem1,
            this.bookToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // patronToolStripMenuItem1
            // 
            this.patronToolStripMenuItem1.Name = "patronToolStripMenuItem1";
            this.patronToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.patronToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.patronToolStripMenuItem1.Text = "Patron";
            this.patronToolStripMenuItem1.Click += new System.EventHandler(this.patronToolStripMenuItem1_Click);
            // 
            // bookToolStripMenuItem1
            // 
            this.bookToolStripMenuItem1.Name = "bookToolStripMenuItem1";
            this.bookToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
            this.bookToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.bookToolStripMenuItem1.Text = "Book";
            // 
            // reportTxt
            // 
            this.reportTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportTxt.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTxt.Location = new System.Drawing.Point(0, 33);
            this.reportTxt.Margin = new System.Windows.Forms.Padding(4);
            this.reportTxt.Multiline = true;
            this.reportTxt.Name = "reportTxt";
            this.reportTxt.ReadOnly = true;
            this.reportTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.reportTxt.Size = new System.Drawing.Size(777, 659);
            this.reportTxt.TabIndex = 1;
            // 
            // Prog2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 692);
            this.Controls.Add(this.reportTxt);
            this.Controls.Add(this.libraryMenuStrip);
            this.MainMenuStrip = this.libraryMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Prog2Form";
            this.Text = "Program 2";
            this.libraryMenuStrip.ResumeLayout(false);
            this.libraryMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip libraryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedOutItemsToolStripMenuItem;
        private System.Windows.Forms.TextBox reportTxt;
        private System.Windows.Forms.ToolStripMenuItem openLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem1;
    }
}


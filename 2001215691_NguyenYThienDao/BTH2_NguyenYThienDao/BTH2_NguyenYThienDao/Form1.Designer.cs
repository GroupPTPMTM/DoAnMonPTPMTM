﻿namespace BTH2_NguyenYThienDao
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
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.mainMenu2 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.userTextBox1 = new UpperTextBox.UserTextBox();
            this.passTextBox1 = new UpperTextBox.PassTextBox();
            this.mailTextBox1 = new UpperTextBox.MailTextBox();
            this.class11 = new UpperTextBox.Class1();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 321);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(449, 22);
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "Xin chào người dùng.....";
            this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
            // 
            // mainMenu2
            // 
            this.mainMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.OwnerDraw = true;
            this.menuItem1.Text = "FIle";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "View";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Edit";
            // 
            // userTextBox1
            // 
            this.userTextBox1.Location = new System.Drawing.Point(115, 124);
            this.userTextBox1.Name = "userTextBox1";
            this.userTextBox1.Size = new System.Drawing.Size(100, 20);
            this.userTextBox1.TabIndex = 3;
            // 
            // passTextBox1
            // 
            this.passTextBox1.Location = new System.Drawing.Point(115, 162);
            this.passTextBox1.Name = "passTextBox1";
            this.passTextBox1.Size = new System.Drawing.Size(100, 20);
            this.passTextBox1.TabIndex = 2;
            // 
            // mailTextBox1
            // 
            this.mailTextBox1.Location = new System.Drawing.Point(115, 98);
            this.mailTextBox1.Name = "mailTextBox1";
            this.mailTextBox1.Size = new System.Drawing.Size(100, 20);
            this.mailTextBox1.TabIndex = 1;
            // 
            // class11
            // 
            this.class11.Location = new System.Drawing.Point(115, 67);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(100, 20);
            this.class11.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 343);
            this.Controls.Add(this.class11);
            this.Controls.Add(this.userTextBox1);
            this.Controls.Add(this.passTextBox1);
            this.Controls.Add(this.mailTextBox1);
            this.Controls.Add(this.statusBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MainMenu mainMenu2;
        private UpperTextBox.MailTextBox mailTextBox1;
        private UpperTextBox.PassTextBox passTextBox1;
        private UpperTextBox.UserTextBox userTextBox1;
        private UpperTextBox.Class1 class11;
    }
}


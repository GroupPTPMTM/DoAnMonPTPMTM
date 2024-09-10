namespace NguyenYThienDao_Buoi3
{
    partial class Form2
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
            this.ucSinhVien1 = new ucLogin.UCSinhVien();
            this.SuspendLayout();
            // 
            // ucSinhVien1
            // 
            this.ucSinhVien1.Cnn = null;
            this.ucSinhVien1.Location = new System.Drawing.Point(53, 12);
            this.ucSinhVien1.Name = "ucSinhVien1";
            this.ucSinhVien1.Size = new System.Drawing.Size(477, 214);
            this.ucSinhVien1.TabIndex = 0;
            this.ucSinhVien1.Load += new System.EventHandler(this.ucSinhVien1_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 272);
            this.Controls.Add(this.ucSinhVien1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucLogin.UCSinhVien ucSinhVien1;
    }
}
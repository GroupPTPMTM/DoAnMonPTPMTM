﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;

namespace ucLogin
{
    public partial class UserControl1: UserControl
    {
        string _cnn;
        int _kq;

        SQLClass sql = new SQLClass();
        public string Cnn
        {
            get { return _cnn; }
            set { _cnn = value; }
        }


        public int Kq
        {
            get { return _kq; }
            set { _kq = value; }
        }
        public UserControl1()
        {
            InitializeComponent();
            this.btnLogin.Click += btnLogin_Click;
        }

        public Button btn_Login { get {return btnLogin;} set{btnLogin = value;}}
        public bool isvalid;

         void btnLogin_Click(object sender, EventArgs e)
        {
            sql.CreateConnection(Cnn);

            
            string ten = txtTen.Text.Trim();
            string mk = txtMK.Text.Trim();
            if (ten != null && mk != null)
            {
                string caulenh = "select COUNT(*) from user_lg where Ten = '" + ten + "' and MK = '" + mk + "' ";

                Kq = (int)sql.ExecuteScalar(caulenh);

                if (Kq == 1)
                {
                    MessageBox.Show("Thanh cong");
                    isvalid = true;
                }
                else
                {
                    MessageBox.Show("That bai");
                    isvalid = false;
                }
            }
            else
                MessageBox.Show("Ten dang nhap hoac mk khong duoc trong");
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

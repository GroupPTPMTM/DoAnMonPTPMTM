﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTH1_2001215691_NguyenYThienDao
{
    public partial class Form1 : Form
    {
        XuLy xuly;
        public Form1()
        {
            InitializeComponent();
            xuly = new XuLy();
            xuly.ds_checkbox(this);
            xuly.button(this);

            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}

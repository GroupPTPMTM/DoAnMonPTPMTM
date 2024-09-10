using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_DBconnect;

namespace NguyenYThienDao_Buoi3
{
    
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Cnn = "Server=A102PC24\\CSSQL08;Database=BT_PTUDTM_3;Integrated Security=True;";
 	        userControl11.Load += userControl11_Load;
            userControl11.btn_Login.Click += btn_Login_Click;
            
        }

        void btn_Login_Click(object sender, EventArgs e)
        {
            if (userControl11.Kq == 1)
            {
                Form2 form = new Form2();
                form.Show();
            }
        }
            
        private void userControl11_Load(object sender, EventArgs e)
        {
            

        }
    }
}

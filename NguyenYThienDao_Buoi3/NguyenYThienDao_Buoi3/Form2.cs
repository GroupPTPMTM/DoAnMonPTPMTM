using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenYThienDao_Buoi3
{
    public partial class Form2 : Form
    {

        int user;
        public int User
        {
            get { return User; }
            set { User = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ucSinhVien1.Cnn = "Server=A102PC24\\CSSQL08;Database=BT_PTUDTM_3;Integrated Security=True;";

            
        }

        private void ucSinhVien1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH2_NguyenYThienDao
{
    public partial class Formdangnhap : Form
    {
        public Formdangnhap()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.ToString();
            Form1 form = new Form1();
            form.Message = name;
            form.ShowDialog();
        }

        private void Formdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn đóng Form không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.No)
                e.Cancel = true;
        }
    }
}

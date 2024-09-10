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
namespace BTH2_NguyenYThienDao
{
    public partial class Form1 : Form
    {
        DBconnect sql;
       
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public Form1()
        {
            InitializeComponent();
            //sql = new DBconnect("asdasdas");
            
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusBar1.Text = _message;
        }
      
        private void menuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
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
    public partial class UCSinhVien : UserControl
    {
        string _cnn;
        public string Cnn
        {
            get { return _cnn; }
            set { _cnn = value; }
        }
        SQLClass sql = new SQLClass();
        public UCSinhVien()
        {
            InitializeComponent();
        }

        public TextBox txtMssv;

        private void txtMSV_TextChanged(object sender, EventArgs e)
        {
            sql.CreateConnection(Cnn);
            
            string msv = txtMSV.Text.Trim();

            if (!string.IsNullOrEmpty(msv))
            {
                string query = "SELECT * FROM sinhvien WHERE msv = '"+msv+"'";
                
                DataTable dt = sql.ExcuteQuery(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    // Assuming you have textboxes for these fields
                    DataRow row = dt.Rows[0];
                    txtTen.Text = row["tensv"].ToString();
                    txtMalop.Text = row["malop"].ToString();
                    txtNgaysinh.Text = row["ngaysinh"].ToString(); // Example for Date of Birth
                    txtGioitinh.Text = row["gioitinh"].ToString();               
                    txtCMND.Text = row["cmnd"].ToString();
                   
                }
                else
                {
                    ClearTextBoxes();
                  
                }
            }
            
        }
        private void ClearTextBoxes()
        {
            
            txtTen.Text = "";
            txtNgaysinh.Text = "";
            txtGioitinh.Text = "";
            txtMalop.Text = "";
            txtCMND.Text = "";
      
        }
        private void UCSinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}

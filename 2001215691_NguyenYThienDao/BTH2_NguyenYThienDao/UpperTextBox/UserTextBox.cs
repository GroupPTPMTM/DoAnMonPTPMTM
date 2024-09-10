using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace UpperTextBox
{
    public class UserTextBox: TextBox
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        public UserTextBox()
        {
            this.KeyPress +=UserTextBox_KeyPress; ;
        }


        void UserTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSymbol(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorProvider.SetError(this, "Username cannot contain special characters.");
            }else
            {
                errorProvider.Clear();
            }
        }
    }
}

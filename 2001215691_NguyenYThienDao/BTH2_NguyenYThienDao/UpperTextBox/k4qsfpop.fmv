using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UpperTextBox
{
    public class PassTextBox: TextBox
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        public PassTextBox() {
            this.KeyPress += PassTextBox_KeyPress;
            this.TextChanged += PassTextBox_TextChanged;
        }

        void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length < 6)
            {
                errorProvider.SetError(this, "Không tồn tại ký tự đặc biệt hoặc ít hơn 6 ký tự");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSymbol(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
               
            }
           
        }
    }
}

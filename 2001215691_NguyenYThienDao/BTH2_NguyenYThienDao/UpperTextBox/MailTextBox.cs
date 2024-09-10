﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace UpperTextBox
{


    public class MailTextBox:TextBox
    {
        private ErrorProvider erorr = new ErrorProvider();
        public MailTextBox()
        {
            this.TextChanged += MailTextBox_TextChanged; ;
        }

        void MailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!this.Text.Contains("@") || !this.Text.Contains(".com"))
            {
                erorr.SetError(this, "Email have @ and .com");
            }
            else
            {
                erorr.Clear();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

     
 
       
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
namespace BTH1_2001215691_NguyenYThienDao
{
    class XuLy
    {
        public void ds_checkbox(Form form)
        {
            string[] foods = { "Grain", "Bread", "Beans", "Eggs", "Chicken", "Milk", "Fruit", "Vegetables", "Pasta", "Rice", "Fish", "Beef" };
            int topPosition = 10;

            foreach (string food in foods)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Left = 10;
                checkBox.Top = topPosition;
                topPosition += 30;
                checkBox.Text = food;
                form.Controls.Add(checkBox);
            }
        }

        public void button(Form form)
        {
            Button b = new Button();
            b.Name = "b1";
            b.Size = new Size(30, 30);
            b.Left = 150;
            b.Top = 20;
            b.Text = "Button";
            form.Controls.Add(b);
            b.Click += new System.EventHandler(bt_click);
            
        }

        public void bt_click(object sender, EventArgs e)
        {
           
        }

       
        public void kq_checkbox(Form form)
        {
            string reward = "";
            foreach (Control item in form.Controls)
            {
                if (item.GetType() == typeof(CheckBox)) {
                    if (((CheckBox)item).Checked)
                    {
                        reward = (item.Text);
                    }         
                } 
            
            }

            MessageBox.Show(reward);
        }


        public void matran(Form form, int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                Button b = null;
             
                for (int j = 0; j < n; j++)
                {
                    b = new Button();
                    b.Size = new Size(30, 30);
                    b.Left +=50 ;
                    b.Top = 10;                   
                    form.Controls.Add(b);
                 
                }
            }
        }

    }
}

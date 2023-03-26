using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_21521865_Tran_Nguyen_Quoc_Bao
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            double a = double.Parse(Num1.Text);
            double b = double.Parse(Num2.Text);
            double c = double.Parse(Num3.Text);
            double max, min;
            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                    if (b > c)
                    {
                        min = c;
                    }
                    else
                    {
                        min = b;
                    }
                }
                else
                {
                    max = c;
                    min = b;
                }
            }
            else
            {
                if (b > c)
                {
                    max = b;
                    if (a > c)
                    {
                        min = c;
                    }
                    else
                    {
                        min = a;
                    }
                }
                else
                {
                    max = c;
                    min = a;
                }
            }
            Min.Text = min.ToString();
            Max.Text = max.ToString();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Num1.Text = "";
            Num2.Text = "";
            Num3.Text = "";
            Min.Text = "";
            Max.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

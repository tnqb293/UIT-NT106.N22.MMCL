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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            int num = int.Parse(EnterNumber.Text);
            string Number = "";
            
            switch (num)
            {
                case 0:
                    Number = "Không"; break;
                case 1:
                    Number = "Một"; break;
                case 2:
                    Number = "Hai"; break;
                case 3:
                    Number = "Ba"; break;
                case 4:
                    Number = "Bốn"; break;
                case 5:
                    Number = "Năm"; break;
                case 6:
                    Number = "Sáu"; break;
                case 7:
                    Number = "Bảy"; break;
                case 8:
                    Number = "Tám"; break;
                case 9:
                    Number = "Chín"; break;
                default:
                    Number = "Không phải là số từ 0 đến 9"; break;

                    

            }
            Result.Text = Number;


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            EnterNumber.Text = "";
            Result.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

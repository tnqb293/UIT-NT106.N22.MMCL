using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1_21521865_Tran_Nguyen_Quoc_Bao
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            List.Items.Add("USD");
            List.Items.Add("EUR");
            List.Items.Add("GBP");
            List.Items.Add("SGD");
            List.Items.Add("JPY");
        }
        private void Change_Click(object sender, EventArgs e)
        {
            double money = double.Parse(Number.Text);
            double rate = 0;

            if (List.SelectedItem.ToString() == "USD")
            {
                rate = 22.2772;
            }
            else if (List.SelectedItem.ToString() == "EUR")
            {
                rate = 28.132;
            }
            else if (List.SelectedItem.ToString() == "GBP")
            {
                rate = 31.538;
            }
            else if (List.SelectedItem.ToString() == "SGD")
            {
                rate = 17.268;
            }
            else if (List.SelectedItem.ToString() == "JPY")
            {
                rate = 214;
            }

            double result = money * rate;
            Result.Text = result.ToString();
        }
    }
}

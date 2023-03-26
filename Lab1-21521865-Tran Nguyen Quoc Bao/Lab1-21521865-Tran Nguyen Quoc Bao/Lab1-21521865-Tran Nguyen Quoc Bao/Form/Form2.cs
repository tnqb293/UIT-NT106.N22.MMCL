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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void Calculator_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(EnterNum1.Text, out int Num1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên vào ô Số A.");
                return;
            }
            if (!int.TryParse(EnterNum2.Text, out int Num2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên vào ô Số B.");
                return;
            }

            // Tính tổng và hiển thị kết quả
            int Sum = Num1 + Num2;
            Result.Text = Sum.ToString();
        }
    }
}

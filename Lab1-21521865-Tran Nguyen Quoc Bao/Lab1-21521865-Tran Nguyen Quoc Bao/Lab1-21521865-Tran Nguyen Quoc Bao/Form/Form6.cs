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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của A và B từ textbox
            int a = int.Parse(EnterNumA.Text);
            int b = int.Parse(EnterNumB.Text);

            // Tính A! và B!
            long aFactorial = 1;
            long bFactorial = 1;
            for (int i = 1; i <= a; i++)
            {
                aFactorial *= i;
            }
            for (int i = 1; i <= b; i++)
            {
                bFactorial *= i;
            }

            // Tính S1 và S2
            int s1 = 0;
            int s2 = 0;
            for (int i = 1; i <= a; i++)
            {
                s1 += i;
            }
            for (int i = 1; i <= b; i++)
            {
                s2 += i;
            }

            // Tính S3
            long s3 = 0;
            for (int i = 1; i <= b; i++)
            {
                s3 += (long)Math.Pow(a, i);
            }

            // Hiển thị kết quả
            ResultAFactorial.Text = aFactorial.ToString();
            ResultBFactorial.Text = bFactorial.ToString();
            ResultS1.Text = s1.ToString();
            ResultS2.Text = s2.ToString();
            ResultS3.Text = s3.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            EnterNumA.Text = "";
            EnterNumB.Text = "";
            ResultAFactorial.Text = "";
            ResultBFactorial.Text = "";
            ResultS1.Text = "";
            ResultS2.Text = "";
            ResultS3.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

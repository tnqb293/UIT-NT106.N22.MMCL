using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_21521865_Tran_Nguyen_Quoc_Bao
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            // Đảm bảo tệp tồn tại trước khi đọc
            if (File.Exists("input1.txt"))
            {
                // Mở tệp để đọc
                using (StreamReader reader = new StreamReader("input1.txt"))
                {
                    // Đọc nội dung và đưa vào RichTextBox
                    Content.Text = reader.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void WriteFile_Click(object sender, EventArgs e)
        {
            /// Chuyển đổi nội dung của RichTextBox thành chữ in hoa
            string upperCaseText = Content.Text.ToUpper();

            // Ghi nội dung vào tệp mới
            File.WriteAllText("output1.txt", upperCaseText);

            MessageBox.Show("File written successfully!");
        }
    }
}

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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại mở tệp tin để chọn tệp tin cần đọc
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Lấy tên tệp tin và đường dẫn tệp tin
                string fileName = ofd.SafeFileName;
                string filePath = ofd.FileName;

                // Tạo đối tượng FileInfo để lấy thông tin kích thước tệp tin
                FileInfo fileInfo = new FileInfo(filePath);
                long fileSizeInBytes = fileInfo.Length;
                string fileSize = $"{fileSizeInBytes / 1024.0:F2} KB"; // Đổi từ byte sang KB

                // Đọc nội dung tệp tin và tính toán số dòng, số từ và số ký tự
                int lineCount = 0;
                int wordCount = 0;
                int charCount = 0;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lineCount++;
                        charCount += line.Length;
                        wordCount += line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    }
                }

                // Hiển thị thông tin tệp tin và nội dung tệp tin trên các TextBox
                FileName.Text = fileName;
                URL.Text = filePath;
                Size.Text = fileSize;
                LineCount.Text = lineCount.ToString();
                WordsCount.Text = wordCount.ToString();
                CharacterCount.Text = charCount.ToString();

                // Đọc nội dung tệp tin và hiển thị lên RichTextBox Content
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Content.Text = reader.ReadToEnd();
                }
            }
        }
    }
}

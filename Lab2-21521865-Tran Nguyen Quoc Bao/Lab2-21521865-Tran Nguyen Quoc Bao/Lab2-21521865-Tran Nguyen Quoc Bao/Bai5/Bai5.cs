using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;


namespace Lab2_21521865_Tran_Nguyen_Quoc_Bao
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Compress_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện nén tập tin "input5.txt"
                string inputFile = "input5.txt";
                string outputFile = "output5.zip";
                using (FileStream inputStream = File.OpenRead(inputFile))
                {
                    using (FileStream outputStream = File.Create(outputFile))
                    {
                        using (GZipStream compressionStream = new GZipStream(outputStream, CompressionMode.Compress))
                        {
                            inputStream.CopyTo(compressionStream);
                        }
                    }
                }
                MessageBox.Show("Đã nén tập tin thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Decompress_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện giải nén tập tin "output5.zip" và lưu trữ dưới dạng "output5.txt"
                string inputFile = "output5.zip";
                string outputFile = "output5.txt";
                using (FileStream inputStream = File.OpenRead(inputFile))
                {
                    using (FileStream outputStream = File.Create(outputFile))
                    {
                        using (GZipStream compressionStream = new GZipStream(inputStream, CompressionMode.Decompress))
                        {
                            compressionStream.CopyTo(outputStream);
                        }
                    }
                }
                MessageBox.Show("Đã giải nén tập tin thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


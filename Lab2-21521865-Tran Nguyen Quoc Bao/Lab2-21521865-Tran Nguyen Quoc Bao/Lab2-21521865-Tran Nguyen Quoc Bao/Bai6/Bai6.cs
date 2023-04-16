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
    public partial class Bai6 : Form
    {
        private string currentPath = "";
        public Bai6()
        {
            InitializeComponent();
            InitializeListView();
        }
        // Lấy thông tin từ máy tính
        private void InitializeListView()
        {
            listView1.LargeImageList = imageList1;
            listView1.SmallImageList = imageList1;
            listView1.View = View.Details;
            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Size", 100);
            listView1.Columns.Add("Type", 100);
            listView1.Columns.Add("Date Modified", 150);
            string[] defaultPaths = new string[] { @"C:\", @"D:\" };
            currentPath = defaultPaths[0]; // Cài đặt mặc định ổ là ổ C, nhấn Switch Drive để chuyển sang ổ D  ( tùy theo máy tính của bạn ) 
            ShowFilesAndFolders(currentPath);
            ShowFilesAndFolders(currentPath);
        }
        // Hiển thị tất cả thư mục và file
        private void ShowFilesAndFolders(string path)
        {
            listView1.Items.Clear();

            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                DirectoryInfo[] subDirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                foreach (DirectoryInfo subDir in subDirs)
                {
                    ListViewItem item = new ListViewItem(subDir.Name);
                    item.ImageIndex = 0;
                    item.SubItems.Add("");
                    item.SubItems.Add("Folder");
                    item.SubItems.Add(subDir.LastWriteTime.ToString());
                    item.Tag = subDir.FullName;
                    listView1.Items.Add(item);
                }

                foreach (FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.ImageIndex = 1;
                    item.SubItems.Add(GetFileSize(file.Length));
                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add(file.LastWriteTime.ToString());
                    item.Tag = file.FullName;
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Lấy Size File
        private string GetFileSize(long size)
        {
            string[] units = { "B", "KB", "MB", "GB", "TB" };
            int index = 0;
            while (size >= 1024 && index < units.Length - 1)
            {
                size /= 1024;
                index++;
            }
            return $"{size} {units[index]}";
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                string path = listView1.SelectedItems[0].Tag.ToString();
                if (Directory.Exists(path))
                {
                    currentPath = path;
                    ShowFilesAndFolders(currentPath);
                }
                else if (File.Exists(path))
                {
                    try
                    {
                        richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        // Trở về thư mục trước đó
        private void Up_Click(object sender, EventArgs e)
        {
            DirectoryInfo parentDirectory = Directory.GetParent(currentPath);

            if (parentDirectory != null)
            {
                currentPath = parentDirectory.FullName;
                ShowFilesAndFolders(currentPath);
            }
        }

        // Chuyển giữa ổ C và ổ D ( tùy theo máy tính của bạn ) 
        private void SWITCH_Click(object sender, EventArgs e)
        {
            if (currentPath.StartsWith(@"C:\"))
            {
                currentPath = @"D:\";
            }
            else
            {
                currentPath = @"C:\";
            }
            ShowFilesAndFolders(currentPath);
        }
    }
}

using System.Data;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using StudentManagement.dto;
using StudentManagement.bll;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        readonly StudentBusinessLogicLayer bll = new();
        readonly Student std = new();

        public Form1()
        {
            InitializeComponent();
            ShowAllStudent();
        }
        public void ShowAllStudent()
        {
            dataGridView1.DataSource = bll.GetAllStudent();
            dataGridView1.Columns[0].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[1].HeaderText = "Họ và tên";
            dataGridView1.Columns[2].HeaderText = "Ngày sinh";
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã số sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ và tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBirth.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBirth.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e) // nút THÊM
        {
            if (CheckData())
            {
                std.Id = txtID.Text;
                std.Name = txtName.Text;
                std.Birth = txtBirth.Text;
                std.Address = txtAddress.Text;

                if (bll.InsertStudent(std))
                    ShowAllStudent();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        private void button2_Click(object sender, EventArgs e) // nút XÓA
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                std.Id = txtID.Text;
                std.Name = txtName.Text;
                std.Birth = txtBirth.Text;
                std.Address = txtAddress.Text;
                if (bll.DeleteStudent(std))
                    ShowAllStudent();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void button3_Click(object sender, EventArgs e) // nút SỬA
        {
            if (CheckData())
            {
                std.Id = txtID.Text;
                std.Name = txtName.Text;
                std.Birth = txtBirth.Text;
                std.Address = txtAddress.Text;

                if (bll.UpdateStudent(std))
                    ShowAllStudent();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e) // nhập Địa chỉ
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtID.Text = dataGridView1.Rows[index].Cells["id"].Value.ToString();
                txtName.Text = dataGridView1.Rows[index].Cells["name"].Value.ToString();
                txtBirth.Text = dataGridView1.Rows[index].Cells["birth"].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[index].Cells["Address"].Value.ToString();
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bll.SearchStudent(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllStudent();
        }

        private void button1_Click_1(object sender, EventArgs e) // nút KẾT NỐI SQL SERVER
        {
            string connectionString = "Data Source=LAPTOP-5OR18CU3;Initial Catalog=StudentManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                MessageBox.Show("Connection opened successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
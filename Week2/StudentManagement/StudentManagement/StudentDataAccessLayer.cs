using System.Data;
using System.Data.SqlClient;
using StudentManagement.dto;

namespace StudentManagement.dal
{
    internal class StudentDataAccessLayer
    {
        private DataConnection? dc;
        private SqlDataAdapter? adapter;
        private SqlCommand? command;
        private SqlConnection? con;
        private DataTable? dt;

        public DataTable GetAllStudent()
        {
            dc = new DataConnection();
            //B1: Tạo câu lệnh lấy toàn bộ danh sách sinh viên
            string sql = "SELECT * FROM Student";
            //B2: Tạo một kết nối đến Sql
            con = dc.getConnect();
            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            adapter = new SqlDataAdapter(sql, con);
            //B4: Mở kết nối
            con.Open();
            //B5: Lấy dữ liệu từ Table
            dt = new();
            adapter.Fill(dt);
            //B6: Đóng kết nối

            

            con.Close();
            return dt;
        }
        public bool InsertStudent(Student student)
        {
            string sql = "INSERT INTO Student(id, name, birth, address) VALUES(@id, @name, @birth, @address)";
            try
            {
                dc = new DataConnection();
                con = dc.getConnect();
                command = new SqlCommand(sql, con);
                con.Open();
                command.Parameters.Add("@id", SqlDbType.Int).Value = student.Id;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = student.Name;
                command.Parameters.Add("@birth", SqlDbType.Date).Value = student.Birth;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = student.Address;
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return false;
            }
        }
        public bool UpdateStudent(Student student)
        {
            dc = new DataConnection();
            con = dc.getConnect();
            string sql = "UPDATE Student SET  name = @name, birth = @birth, address = @address WHERE id = @id";
            try
            {
                command = new SqlCommand(sql, con);
                con.Open();
                command.Parameters.Add("@id", SqlDbType.Int).Value = student.Id;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = student.Name;
                command.Parameters.Add("@birth", SqlDbType.Date).Value = student.Birth;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = student.Address;
                command.ExecuteNonQuery();
                con.Close();
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool DeleteStudent(Student student)
        {
            dc = new DataConnection();
            con = dc.getConnect();
            string sql = "DELETE Student WHERE id = @id";
            try
            {
                command = new SqlCommand(sql, con);
                con.Open();
                command.Parameters.Add("@id", SqlDbType.Int).Value = student.Id;
                command.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                return false;
            }
            return true;
        }
        public DataTable SearchStudent(string student)
        {
            // Tạo một kết nối đến Sql
            dc = new DataConnection();
            con = dc.getConnect();
            string sql = "SELECT * FROM Student WHERE name like '%" + student + "%'";
            // Khởi tạo đối tượng của lớp SqlDataAdapter
            adapter = new SqlDataAdapter(sql, con);
            // Mở kết nối
            con.Open();
            // Lấy dữ liệu từ Table
            dt = new DataTable();
            adapter.Fill(dt);
            // Đóng kết nối
            con.Close();
            return dt;
        }
    }
}


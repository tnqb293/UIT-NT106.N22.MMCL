using StudentManagement.dal;
using StudentManagement.dto;
using System.Data;

namespace StudentManagement.bll
{
    internal class StudentBusinessLogicLayer
    {
        readonly StudentDataAccessLayer dal = new();
        public DataTable GetAllStudent()
        {
            return dal.GetAllStudent();

        }
        public bool InsertStudent(Student student)
        {
            return dal.InsertStudent(student);
        }
        public bool UpdateStudent(Student student)
        {
            return dal.UpdateStudent(student);
        }
        public bool DeleteStudent(Student student)
        {
            return dal.DeleteStudent(student);
        }
        public DataTable SearchStudent(string student)
        {
            return dal.SearchStudent(student);
        }

    }
}

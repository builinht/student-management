using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public StudentObject GetStudentByID(string StudentID) => StudentDAO.Instance.GetStudentByID(StudentID);
        public IEnumerable<StudentObject> GetStudents() => StudentDAO.Instance.GetStudentList();
        public void InsertStudent(StudentObject student) => StudentDAO.Instance.AddNew(student);
        public void DeleteStudent(string StudentID) => StudentDAO.Instance.Remove(StudentID);
        public void UpdateStudent(StudentObject student) => StudentDAO.Instance.Update(student);
    }
}

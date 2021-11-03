using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<StudentObject> GetStudents();
        StudentObject GetStudentByID(string StudentID);
        void InsertStudent(StudentObject student);
        void DeleteStudent(string StudentID);
        void UpdateStudent(StudentObject student);
    }
}

using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICourseRepository
    {
        IEnumerable<CourseObject> GetCourses();
        CourseObject GetCourseByID(int courseID);
        void InsertCourse(CourseObject course);
        void DeleteCourse(int courseID);
        void UpdateCourse(CourseObject course);
    }
}

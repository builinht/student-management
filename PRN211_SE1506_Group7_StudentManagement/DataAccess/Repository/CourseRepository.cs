using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CourseRepository : ICourseRepository
    {
        public CourseObject GetCourseByID(int courseID) => CourseDAO.Instance.GetCourseByID(courseID);
        public IEnumerable<CourseObject> GetCourses() => CourseDAO.Instance.GetCourseList();
        public void InsertCourse(CourseObject course) => CourseDAO.Instance.AddCourse(course);
        public void DeleteCourse(int courseID) => CourseDAO.Instance.RemoveCourse(courseID);
        public void UpdateCourse(CourseObject course) => CourseDAO.Instance.UpdateCourse(course);
    }
}

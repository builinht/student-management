using BusinessObject;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class tblCourseRepository : ItblCourseRepository
    {
        public void DeletetblCourse(int CourseId) => tblCourseDAO.Instance.Remove(CourseId);


        public tblCourse GettblCourseByID(int CourseId) => tblCourseDAO.Instance.GettblcourseByID(CourseId);


        public IEnumerable<tblCourse> GettblCourses() => tblCourseDAO.Instance.GettblCourseList();


        public void InserttblCourse(tblCourse course) => tblCourseDAO.Instance.AddNew(course);


        public void UpdatetblCourse(tblCourse course) => tblCourseDAO.Instance.Update(course);

    }
}

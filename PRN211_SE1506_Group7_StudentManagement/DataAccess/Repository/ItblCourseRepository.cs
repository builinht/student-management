using BusinessObject;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ItblCourseRepository
    {
        IEnumerable<tblCourse> GettblCourses();
        tblCourse GettblCourseByID(int CourseId);
        void InserttblCourse(tblCourse Course);
        void DeletetblCourse(int CourseId);
        void UpdatetblCourse(tblCourse Course);
    }
}

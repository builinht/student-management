using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CourseDAO : BaseDAL
    {
        private static CourseDAO instance = null;
        private static readonly object instanceLock = new object();
        private CourseDAO() { }
        public static CourseDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CourseDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<CourseObject> GetCourseList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select courseID, subjectID, courseName from tblCourse";
            var courses = new List<CourseObject> ();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    courses.Add(new CourseObject
                    {
                        courseID = dataReader.GetInt32(0),
                        subjectID = dataReader.GetString(1),
                        courseName = dataReader.GetString(2)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return courses;
        }

        public CourseObject GetCourseByID(int courseID)
        {
            CourseObject course = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select courseID, subjectID, courseName from tblCourse where courseID = @courseID";
            try
            {
                var param = dataProvider.CreateParameter("@courseID", 10, courseID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    course = new CourseObject
                    {
                        courseID = dataReader.GetInt32(0),
                        subjectID = dataReader.GetString(1),
                        courseName = dataReader.GetString(2)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return course;
        }

        public void AddCourse(CourseObject course)
        {
            try
            {
                CourseObject pro = GetCourseByID(course.courseID);
                if (pro == null)
                {
                    string SQLInsert = "Insert tblCourse values(@courseID,@subjectID,@courseName)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@courseID", 10, course.courseID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@subjectID", 20, course.subjectID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@courseName", 50, course.courseName, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The course is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void UpdateCourse(CourseObject course)
        {
            try
            {
                CourseObject m = GetCourseByID(course.courseID);
                if (m != null)
                {
                    string SQLUpdate = "Update tblCourse set subjectID= @subjectID, courseName = @courseName where courseID=@courseID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@courseID", 10, course.courseID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@subjectID", 20, course.subjectID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@courseName", 50, course.courseName, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The course does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void RemoveCourse(int courseID)
        {
            try
            {
                CourseObject course = GetCourseByID(courseID);
                if (course != null)
                {
                    string SQLDelete = "Delete tblCourse where courseID = @courseID";
                    var param = dataProvider.CreateParameter("@courseID", 10, courseID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The course does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}

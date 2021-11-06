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
    public class tblCourseDAO : BaseDAL
    {
        private static tblCourseDAO instance = new tblCourseDAO();
        private static readonly object instanceLock = new object();
        private tblCourseDAO() { }
        public static tblCourseDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new tblCourseDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<tblCourse> GettblCourseList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select courseID , CourseName, subjectiD from tblCourse  ";
            var courses = new List<tblCourse>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    courses.Add(new tblCourse
                    {
                        courseID = dataReader.GetInt32(0),
                        courseName = dataReader.GetString(1),
                        subjectID = dataReader.GetString(2)
                    }
                        );
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
        //-----------------------------------------
        public tblCourse GettblcourseByID(int courseId)
        {
            var courses = new tblCourse();
            string SQLSelect = "Select  courseID , courseName, subjectID from tblCourse Where courseID = " + courseId + "";
            IDataReader dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);

            try
            {
                //var param = dataProvider.CreateParameter("@courseID", 0, courseId, DbType.Int32);

                if (dataReader.Read())
                {
                    courses = new tblCourse
                    {
                        courseID = dataReader.GetInt32(0),
                        courseName = dataReader.GetString(1),
                        subjectID = dataReader.GetString(2)

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
            return courses;
        }
        //-----------------------------------------------
        public void AddNew(tblCourse courses)
        {
            try
            {
                tblCourse c = GettblcourseByID(courses.courseID);
                if (c != null)
                {
                    string SQLInsert = " Insert INTO tblCourse Values (" + courses.courseID+ ", '"+courses.courseName+"', '" + courses.subjectID + "')";
                    var parameters = new List<SqlParameter>();
                    //parameters.Add(dataProvider.CreateParameter("@CourseId", 20, courses.courseID, DbType.Int32));
                    //parameters.Add(dataProvider.CreateParameter("@CourseName", 50, courses.courseName, DbType.String));
                    //parameters.Add(dataProvider.CreateParameter("@subjectID", 20, courses.subjectID, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("This Course is existed");
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

        public void Update(tblCourse courses)
        {
            try
            {
                tblCourse c = GettblcourseByID(courses.courseID);
                if (c != null)
                {

                    string SQLUpdate = "Update tblCourse set courseName=@courseName,subjectID=@subjectID  where courseID=@courseID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CourseID", 20, courses.courseID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CourseName", 50, courses.courseName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@subjectID", 20, courses.subjectID, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("This tblCourse does not exist");
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
        //------------------------------------------------------
        public void Remove(int courseId)
        {
            try
            {
                tblCourse c = GettblcourseByID(courseId);
                if (c != null)
                {
                    string SQLDelete = " Delete tblCourse where CourseID="+courseId+"";
                    //var param = dataProvider.CreateParameter("@CourseID", 20, courseId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text);
                }
                else
                {
                    throw new Exception("The car does not already exist.");
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

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
    public class MarkDAO : BaseDAL
    {
        private static MarkDAO instance = null;
        private static readonly object instaceLock = new object();
        private MarkDAO() { }
        public static MarkDAO Instance
        {
            get
            {
                lock (instaceLock)
                {
                    if (instance == null)
                    {
                        instance = new MarkDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<MarkObject> GetMarkList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select courseID, studentID, Assignment, Practical, Final, GPA from tblMark";
            var cars = new List<MarkObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    cars.Add(new MarkObject
                    {
                        courseID = dataReader.GetInt32(0),
                        studentID = dataReader.GetString(1),
                        Assignment = dataReader.GetInt32(2),
                        Practical = dataReader.GetInt32(3),
                        Final = dataReader.GetInt32(4),
                        GPA = dataReader.GetInt32(5)
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
            return cars;
        }

        public MarkObject GetMarkByCoIDAndStID(int courseID, string studentID)
        {
            MarkObject mark = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select courseID, studentID, Assignment, Practical, Final, GPA from tblMark where courseID=@courseID and studentID = @studentID";
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@courseID", 10, courseID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@studentID", 20, studentID, DbType.String));

                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                if (dataReader.Read())
                {
                    mark = new MarkObject
                    {
                        courseID = dataReader.GetInt32(0),
                        studentID = dataReader.GetString(1),
                        Assignment = dataReader.GetInt32(2),
                        Practical = dataReader.GetInt32(3),
                        Final = dataReader.GetInt32(4),
                        GPA = dataReader.GetInt32(5)
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
            return mark;
        }

        public void AddMark(MarkObject mark)
        {
            try
            {
                MarkObject m = GetMarkByCoIDAndStID(mark.courseID, mark.studentID);
                if (m == null)
                {

                    string SQLInsert = " Insert tblMark  values (@courseID,@studentID,@Assignment,@Practical,@Final,@GPA)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@courseID", 10, mark.courseID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@studentID", 20, mark.studentID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Assignment", 10, mark.Assignment, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Practical", 10, mark.Practical, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Final", 10, mark.Final, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@GPA", 10, mark.GPA, DbType.Int32));

                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());

                }
                else
                {
                    throw new Exception("This Mark is existed");
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

        public void UpdateMark(MarkObject mark)
        {
            try
            {
                MarkObject m = GetMarkByCoIDAndStID(mark.courseID, mark.studentID);
                if (m != null)
                {

                    string SQLInsert = " Update tblMark Set Assignment=@Assignment, Practical=@Practical, Final=@Final, GPA=@GPA Where courseID=@courseID and studentID=@studentID ";
                    var parameters = new List<SqlParameter>();

                    parameters.Add(dataProvider.CreateParameter("@courseID", 10, mark.courseID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@studentID", 20, mark.studentID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Assignment", 10, mark.Assignment, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Practical", 10, mark.Practical, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Final", 10, mark.Final, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@GPA", 10, mark.GPA, DbType.Int32));
                    dataProvider.Update(SQLInsert, CommandType.Text, parameters.ToArray());

                }
                else
                {
                    throw new Exception("This Mark is existed");
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

        public void RemoveMark(int courseID, string studentID)
        {
            try
            {
                MarkObject o = GetMarkByCoIDAndStID(courseID, studentID);
                if (o != null)
                {
                    string SQLDelete = " Delete tblMark where courseID=@courseID and studentID = @studentID ";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@courseID", 10, courseID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@studentID", 20, studentID, DbType.String));
                    dataProvider.Delete(SQLDelete, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Mark does not exist.");
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

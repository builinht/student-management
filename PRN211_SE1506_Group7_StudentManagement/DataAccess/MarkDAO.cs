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
        private static readonly object instanceLock = new object();
        private MarkDAO() { }
        public static MarkDAO Instance
        {
            get
            {
                lock (instanceLock)
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
            string SQLSelect = "Select courseID, studentID, Assignment, Practical, Final from tblMark  ";
            var mark = new List<MarkObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    mark.Add(new MarkObject
                    {
                        courseID = dataReader.GetInt32(0),
                        studentID = dataReader.GetString(1),
                        Assignment = dataReader.GetDouble(2),
                        Practical = dataReader.GetDouble(3),
                        Final = dataReader.GetDouble(4)
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
            return mark;
        }

        public MarkObject GetMarkByCoIDAndStID(int courseID, string studentID)
        {
            MarkObject mark = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select courseID, studentID, Assignment, Practical, Final from tblMark where courseID=@courseID and studentID = @studentID";
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
                        Assignment = dataReader.GetDouble(2),
                        Practical = dataReader.GetDouble(3),
                        Final = dataReader.GetDouble(4)
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

                    string SQLInsert = " Insert tblMark  Values (@courseID,@studentID,@Assignment,@Practical,@Final)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@courseID", 10, mark.courseID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@studentID", 20, mark.studentID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Assignment", 10, mark.Assignment, DbType.Double));
                    parameters.Add(dataProvider.CreateParameter("@Practical", 10, mark.Practical, DbType.Double));
                    parameters.Add(dataProvider.CreateParameter("@Final", 10, mark.Final, DbType.Double));

                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());

                }
                else
                {
                    throw new Exception("This mark is existed");
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
                MarkObject o = GetMarkByCoIDAndStID(mark.courseID, mark.studentID);
                if (o != null)
                {
                    string SQLUpdate = "Update tblMark set Assignment=@Assignment ,Practical=@Practical, Final=@Final where courseID=@courseID and studentID=@studentID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@courseID", 10, mark.courseID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@studentID", 20, mark.studentID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Assignment", 10, mark.Assignment, DbType.Double));
                    parameters.Add(dataProvider.CreateParameter("@Practical", 10, mark.Practical, DbType.Double));
                    parameters.Add(dataProvider.CreateParameter("@Final", 10, mark.Final, DbType.Double));

                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The mark does not already exist.");
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
                    string SQLDelete = "Delete tblMark where courseID=@courseID and studentID=@studentID";
                    var parameters = new List<SqlParameter>();

                    parameters.Add(dataProvider.CreateParameter("@courseID", 10, courseID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@studentID", 20, studentID, DbType.String));
                    dataProvider.Delete(SQLDelete, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The mark does not exist.");
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

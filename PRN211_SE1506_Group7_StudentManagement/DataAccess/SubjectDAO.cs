using System;
using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class SubjectDAO : BaseDAL
    {
        private static SubjectDAO instance = null;
        private static readonly object instanceLock = new object();
        private SubjectDAO() { }
        public static SubjectDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SubjectDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<SubjectObject> GetSubjectList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select subjectID, majorID, subjectName from tblSubject";
            var subjects = new List<SubjectObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    subjects.Add(new SubjectObject
                    {
                        subjectID = dataReader.GetString(0),
                        majorID = dataReader.GetString(1),
                        subjectName = dataReader.GetString(2)
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
            return subjects;
        }

        public SubjectObject GetSubjectByID(string subjectID)
        {
            SubjectObject subject = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select subjectID, majorID, subjectName from tblSubject where subjectID = @subjectID";
            try
            {
                var param = dataProvider.CreateParameter("@subjectID", 20, subjectID, DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    subject = new SubjectObject
                    {
                        subjectID = dataReader.GetString(0),
                        majorID = dataReader.GetString(1),
                        subjectName = dataReader.GetString(2)
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
            return subject;
        }

        public void AddSubject(SubjectObject subject)
        {
            try
            {
                SubjectObject pro = GetSubjectByID(subject.subjectID);
                if (pro == null)
                {
                    string SQLInsert = "Insert tblSubject values(@subjectID,@majorID,@subjectName)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@subjectID", 20, subject.subjectID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@majorID", 20, subject.majorID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@subjectName", 50, subject.subjectName, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The subject is already exist.");
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

        public void UpdateSubject(SubjectObject subject)
        {
            try
            {
                SubjectObject m = GetSubjectByID(subject.subjectID);
                if (m != null)
                {
                    string SQLUpdate = "Update tblSubject set majorID=@majorID, subjectName=@subjectName where subjectId=@subjectId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@subjectID", 20, subject.subjectID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@majorID", 20, subject.majorID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@subjectName", 50, subject.subjectName, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The subject does not already exist.");
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
        public void RemoveSubject(string subjectID)
        {
            try
            {
                SubjectObject subject = GetSubjectByID(subjectID);
                if (subject != null)
                {
                    string SQLDelete = "Delete tblSubject where subjectID = @subjectID";
                    var param = dataProvider.CreateParameter("@subjectID", 20, subjectID, DbType.String);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The subject does not already exist.");
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

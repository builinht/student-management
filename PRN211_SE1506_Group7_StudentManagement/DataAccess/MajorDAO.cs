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
    public class MajorDAO : BaseDAL
    {
        private static MajorDAO instance = null;
        private static readonly object instanceLock = new object();
        private MajorDAO() { }
        public static MajorDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MajorDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<MajorObject> GetMajorList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select majorID, majorName from tblMajor";
            var majors = new List<MajorObject> ();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    majors.Add(new MajorObject
                    {
                        majorID = dataReader.GetString(0),
                        majorName = dataReader.GetString(1)
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
            return majors;
        }

        public MajorObject GetMajorByID(string majorID)
        {
            MajorObject major = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select majorID,majorName from tblMajor where majorID = @majorID";
            try
            {
                var param = dataProvider.CreateParameter("@majorID", 20, majorID, DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    major = new MajorObject
                    {
                        majorID = dataReader.GetString(0),
                        majorName = dataReader.GetString(1)
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
            return major;
        }

        public void AddMajor(MajorObject major)
        {
            try
            {
                MajorObject pro = GetMajorByID(major.majorID);
                if (pro == null)
                {
                    string SQLInsert = "Insert tblMajor values(@majorID,@majorName)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@majorID", 20, major.majorID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@majorName", 50, major.majorName, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The major is already exist.");
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

        public void UpdateMajor(MajorObject major)
        {
            try
            {
                MajorObject m = GetMajorByID(major.majorID);
                if (m != null)
                {
                    string SQLUpdate = "Update tblMajor set majorName = @majorName where majorID=@majorID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@majorID", 20, major.majorID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@majorName", 50, major.majorName, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The major does not already exist.");
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

        public void RemoveMajor(string majorID)
        {
            try
            {
                MajorObject major = GetMajorByID(majorID);
                if (major != null)
                {
                    string SQLDelete = "Delete tblMajor where majorID = @majorID";
                    var param = dataProvider.CreateParameter("@majorID",20, majorID, DbType.String);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The major does not already exist.");
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

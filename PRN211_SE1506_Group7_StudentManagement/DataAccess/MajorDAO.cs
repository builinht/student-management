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

        public IEnumerable<MajorObject> GettblMajorList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select majorID, majorName from tblMajor  ";
            var majors = new List<MajorObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    majors.Add(new MajorObject
                    {
                        MajorId = dataReader.GetString(0),
                        NameMajor = dataReader.GetString(2),
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
            return majors;
        }

        public MajorObject GettblMajorByID(string MajorId)
        {
            MajorObject majors = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select majorID ,majorName from tblMajor Where majorID=@majorID";
            try
            {
                var param = dataProvider.CreateParameter("@majorID", 50, MajorId, DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    majors = new MajorObject
                    {
                        MajorId = dataReader.GetString(0),
                        NameMajor = dataReader.GetString(1),

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
            return majors;

        }

        public void AddNew(MajorObject majors)
        {
            try
            {
                MajorObject m = GettblMajorByID(majors.MajorId);
                if (m == null)
                {
                    string SQLInsert = " Insert tblMajor Values (@majorID,@majorName)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@majorID", 20, majors.MajorId, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@majorName", 50, majors.NameMajor, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("This tblMajor is existed");
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

        public void Update(MajorObject majors)
        {
            try
            {
                MajorObject m = GettblMajorByID(majors.MajorId);
                if (m != null)
                {

                    string SQLUpdate = "Update tblMajor set majorName=@majorName where majorID=@majorID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@majorID", 20, majors.MajorId, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@majorName", 50, majors.NameMajor, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("This tblMajor does not exist");
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

        public void Remove(string majorId)
        {
            try
            {
                MajorObject m = GettblMajorByID(majorId);
                if (m != null)
                {
                    string SQLDelete = " Delete tblMajor where majorID=@majorID";
                    var param = dataProvider.CreateParameter("@majorID", 20, majorId, DbType.String);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The tblMajor does not already exist.");
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

using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDAO : BaseDAL
    {
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        private UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }
        //------------------------------------

        public IEnumerable<UserObject> GetUserList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select email ,password from tblUser  ";
            var users = new List<UserObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    users.Add(new UserObject
                    {
                        UserEmail = dataReader.GetString(0),
                        UserPassword = dataReader.GetString(1)
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
            return users;
        }
    }
}

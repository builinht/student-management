using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace DataAccess
{
    public class StudentDAO : BaseDAL
    {
        private static StudentDAO instance = null;
        private static readonly object instanceLock = new object();
        private StudentDAO() { }
        public static StudentDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StudentDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<StudentObject> GetStudentList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select studentID ,fullname ,birthday ,gender ,address ,phone ,email ,birthplace ,majorID from tblStudent ";
            var students = new List<StudentObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    students.Add(new StudentObject
                    {
                        StudentID = dataReader.GetString(0),
                        StudentName = dataReader.GetString(1),
                        BirthDate = dataReader.GetDateTime(2),
                        StudentGender = dataReader.GetInt32(3),
                        StudentAddress = dataReader.GetString(4),
                        StudentPhone = dataReader.GetString(5),
                        StudentEmail = dataReader.GetString(6),
                        BirthPlace = dataReader.GetString(7),
                        MajorId = dataReader.GetString(8),
                    }
                    );
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return students;
        }
        //-------------------------------------------
        public StudentObject GetStudentByID(string StudentID)
        {
            StudentObject student = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select studentID ,fullname ,birthday ,gender ,address ,phone ,email ,birthplace ,majorID from tblStudent Where studentID=@studentID";
            try
            {
                var param = dataProvider.CreateParameter("@studentID", 100, StudentID, DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    student = new StudentObject
                    {
                        StudentID = dataReader.GetString(0),
                        StudentName = dataReader.GetString(1),
                        BirthDate = dataReader.GetDateTime(2),
                        StudentGender = dataReader.GetInt32(3),
                        StudentAddress = dataReader.GetString(4),
                        StudentPhone = dataReader.GetString(5),
                        StudentEmail = dataReader.GetString(6),
                        BirthPlace = dataReader.GetString(7),
                        MajorId = dataReader.GetString(8),
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
            return student;

        }
        public void AddNew(StudentObject student)
        {
            try
            {
                StudentObject st = GetStudentByID(student.StudentID);
                if (st == null)
                {
                    string SQLInsert = " Insert tblStudent Values (@studentID,@fullname,@birthday,@gender,@address,@phone,@email,@birthplace,@majorID)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@studentID", 100, student.StudentID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@fullname", 100, student.StudentName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@birthday", 100, student.BirthDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@gender", 4, student.StudentGender, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@address", 100, student.StudentAddress, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@phone", 100, student.StudentPhone, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@email", 100, student.StudentEmail, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@birthplace", 100, student.BirthPlace, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@majorID", 100, student.MajorId, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(StudentObject student)
        {
            try
            {
                StudentObject st = GetStudentByID(student.StudentID);
                if(st != null)
                {
                    string SQLUpdate = "Update tblStudent set fullname=@fullname , birthday=@birthday , gender=@gender , address=@address , phone=@phone , email=@email , birthplace=@birthplace , majorID=@majorID where studentID=@studentID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@studentID", 100, student.StudentID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@fullname", 100, student.StudentName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@birthday", 100, student.BirthDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@gender", 4, student.StudentGender, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@address", 100, student.StudentAddress, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@phone", 100, student.StudentPhone, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@email", 100, student.StudentEmail, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@birthplace", 100, student.BirthPlace, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@majorID", 100, student.MajorId, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
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
        public void Remove(string StudentID)
        {
            try
            {
                StudentObject st = GetStudentByID(StudentID);
                if(st != null)
                {
                    string SQLDelete = " Delete tblStudent where studentID=@studentID ";
                    var param = dataProvider.CreateParameter("@studentID", 100, StudentID, DbType.String);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The student does not exist.");
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

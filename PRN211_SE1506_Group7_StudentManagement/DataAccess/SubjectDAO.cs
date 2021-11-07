﻿using System;
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

        public IEnumerable<SubjectObject> GetSubjectsList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select subjectID, subjectName, sajorID from tblSubject";
            var subjects = new List<SubjectObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    subjects.Add(new SubjectObject
                    {
                        SubjectID = dataReader.GetString(0),
                        SubjectName = dataReader.GetString(1),
                        MajorID = dataReader.GetString(2)
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
            string SQLSelect = "Select subjectName, majorID from tblSubject where subjectID = @subjectID";
            try
            {
                var param = dataProvider.CreateParameter("@subjectID", 20, subjectID, DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    subject = new SubjectObject
                    {
                        SubjectID = dataReader.GetString(0),
                        SubjectName = dataReader.GetString(1),
                        MajorID = dataReader.GetString(2)
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

        public void AddNew(SubjectObject subject)
        {
            try
            {
                SubjectObject pro = GetSubjectByID(subject.SubjectID);
                if (pro == null)
                {
                    string SQLInsert = "Insert tblSubject values(@subjectID,@subjectName,@majorID)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@subjectID", 20, subject.SubjectID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@subjectName", 20, subject.SubjectName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@majorID", 20, subject.MajorID, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The subjet is already exist. ");
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

        public void Update(SubjectObject subject)
        {
            try
            {
                SubjectObject c = GetSubjectByID(subject.SubjectID);
                if (c != null)
                {
                    string SQLUpdate = "Update tblSubject set subjectName = @subjectName, majorID = majorID where subjectID = @subjectID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@subjectID", 20, subject.SubjectID, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@subjectName", 20, subject.SubjectName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@majorID", 20, subject.MajorID, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The subjet does not exist. ");
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
        public void Remove(string subjectID)
        {
            try
            {
                SubjectObject sub = GetSubjectByID(subjectID);
                if (sub != null)
                {
                    string SQLDelete = "Delete tblSubject where subjectID = @subjectID";
                    var param = dataProvider.CreateParameter("@subjectID", 20, subjectID, DbType.String);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The subjet is already exist. ");
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

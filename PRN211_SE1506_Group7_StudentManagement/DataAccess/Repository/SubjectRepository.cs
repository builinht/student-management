using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        public SubjectObject GetSubjectByID(string SubjectID) => SubjectDAO.Instance.GetSubjectByID(SubjectID);
        public IEnumerable<SubjectObject> GetSubjects() => SubjectDAO.Instance.GetSubjectsList();
        public void InsertSubject(SubjectObject subject) => SubjectDAO.Instance.AddNew(subject);
        public void DeleteSubject(string SubjectID) => SubjectDAO.Instance.Remove(SubjectID);
        public void UpdateSubject(SubjectObject subject) => SubjectDAO.Instance.Update(subject);
    }
}

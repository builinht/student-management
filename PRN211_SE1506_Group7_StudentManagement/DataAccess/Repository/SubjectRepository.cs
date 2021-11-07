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
        public SubjectObject GetSubjectByID(string subjectID) => SubjectDAO.Instance.GetSubjectByID(subjectID);
        public IEnumerable<SubjectObject> GetSubjects() => SubjectDAO.Instance.GetSubjectList();
        public void InsertSubject(SubjectObject subject) => SubjectDAO.Instance.AddSubject(subject);
        public void DeleteSubject(string subjectID) => SubjectDAO.Instance.RemoveSubject(subjectID);
        public void UpdateSubject(SubjectObject subject) => SubjectDAO.Instance.UpdateSubject(subject);
    }
}

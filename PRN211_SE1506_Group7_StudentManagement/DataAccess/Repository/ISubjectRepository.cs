using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface ISubjectRepository
    {
        IEnumerable<SubjectObject> GetSubjects();
        SubjectObject GetSubjectByID(string subjectID);
        void InsertSubject(SubjectObject subject);
        void DeleteSubject(string subjectID);
        void UpdateSubject(SubjectObject subject);
    }
}

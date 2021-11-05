using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MarkRepository : IMarkRepository
    {
        public MarkObject GetMarkByCoIDAndStID(int courseID, string studentID) => MarkDAO.Instance.GetMarkByCoIDAndStID(courseID, studentID);
        public IEnumerable<MarkObject> GetMarks() => MarkDAO.Instance.GetMarkList();
        public void InsertMark(MarkObject mark) => MarkDAO.Instance.AddMark(mark);
        public void DeleteMark(int courseID, string studentID) => MarkDAO.Instance.RemoveMark(courseID, studentID);
        public void UpdateMark(MarkObject mark) => MarkDAO.Instance.UpdateMark(mark);
    }
}

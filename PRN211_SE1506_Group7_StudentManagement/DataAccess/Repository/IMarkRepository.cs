using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMarkRepository
    {
        IEnumerable<MarkObject> GetMarks();
        MarkObject GetMarkByCoIDAndStID(int courseID, string studentID);
        void InsertMark(MarkObject mark);
        void DeleteMark(int courseID, string studentID);
        void UpdateMark(MarkObject mark);
    }
}

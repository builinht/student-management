using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMajorRepository
    {
        IEnumerable<MajorObject> GetMajors();
        MajorObject GetMajorByID(string majorID);
        void InsertMajor(MajorObject major);
        void DeleteMajor(string majorID);
        void UpdateMajor(MajorObject major);
    }
}

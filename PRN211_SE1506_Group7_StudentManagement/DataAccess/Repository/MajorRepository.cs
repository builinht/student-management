using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MajorRepository : IMajorRepository
    {
        public MajorObject GetMajorByID(string majorID) => MajorDAO.Instance.GetMajorByID(majorID);
        public IEnumerable<MajorObject> GetMajors() => MajorDAO.Instance.GetMajorList();
        public void InsertMajor(MajorObject major) => MajorDAO.Instance.AddMajor(major);
        public void DeleteMajor(string majorID) => MajorDAO.Instance.RemoveMajor(majorID);
        public void UpdateMajor(MajorObject major) => MajorDAO.Instance.UpdateMajor(major);
    }
}

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
        public MajorObject GettblMajorByID(string MajorId) => MajorDAO.Instance.GettblMajorByID(MajorId);
        public IEnumerable<MajorObject> GettblMajors() => MajorDAO.Instance.GettblMajorList();
        public void InserttblMajor(MajorObject majors) => MajorDAO.Instance.AddNew(majors);
        public void DeletetblMajor(string majorId) => MajorDAO.Instance.Remove(majorId);
        public void UpdatetblMajor(MajorObject majors) => MajorDAO.Instance.Update(majors);
    }
}

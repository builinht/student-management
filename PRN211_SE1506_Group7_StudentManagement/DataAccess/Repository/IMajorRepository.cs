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
        IEnumerable<MajorObject> GettblMajors();
        MajorObject GettblMajorByID(string MajorId);
        void InserttblMajor(MajorObject majors);
        void DeletetblMajor(string majorId);
        void UpdatetblMajor(MajorObject majors);
    }
}

using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IExpertRepository
    {
        Expert GetExpertByEmail(String email);

        IEnumerable<Expert> GetExperts();
        Expert GetExpertByID(int id);
        void DeleteExpert(int id);
        void UpdateExpert(Expert expert);
        void InsertExpert(Expert expert);
    }
}

using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ExpertRepository : IExpertRepository
    {
        public void DeleteExpert(int id) => ExpertDAO.Instance.DeleteExpert(id);

        public Expert GetExpertByID(int id) => ExpertDAO.Instance.GetExpertById(id);

        public IEnumerable<Expert> GetExperts() => ExpertDAO.Instance.GetExperts();

        public void InsertExpert(Expert expert) => ExpertDAO.Instance.InsertExpert(expert);

        public void UpdateExpert(Expert expert) => ExpertDAO.Instance.UpdateExpert(expert);
    }
}

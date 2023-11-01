using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CageRepository : ICageRepository
    {
        public IEnumerable<Cage> GetCages() => CageDAO.Instance.GetCages();

        public List<Cage> GetCagesByExpertEmail(string expertEmail) => CageDAO.Instance.GetCagesByExpertEmail(expertEmail);
    

        public List<Cage> GetCagesByStaffEmail(string staffEmail) => CageDAO.Instance.GetCagesByStaffEmail(staffEmail);
    }
}

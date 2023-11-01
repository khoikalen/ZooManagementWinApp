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
        public void DeleteCage(int id) => CageDAO.Instance.DeleteCage(id);

        public Cage GetCageById(int id) => CageDAO.Instance.GetCageById(id);

        public IEnumerable<Cage> GetCages() => CageDAO.Instance.GetCages();

<<<<<<< HEAD
        public List<Cage> GetCagesByExpertEmail(string expertEmail) => CageDAO.Instance.GetCagesByExpertEmail(expertEmail);
    
=======

        public void InsertCage(Cage cage) => CageDAO.Instance.InsertCage(cage);

        public void UpdateCage(Cage cage) => CageDAO.Instance.UpdateCage(cage); 
>>>>>>> 4cc1e79d88277d7bf274d2208cf382a8007c5ee9

        public List<Cage> GetCagesByStaffEmail(string staffEmail) => CageDAO.Instance.GetCagesByStaffEmail(staffEmail);

    }
}

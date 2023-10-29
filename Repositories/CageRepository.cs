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
        public void InsertCage(Cage cage) => CageDAO.Instance.InsertCage(cage);

        public void UpdateCage(Cage cage) => CageDAO.Instance.UpdateCage(cage); 
=======
        public List<Cage> GetCagesByStaffEmail(string staffEmail) => CageDAO.Instance.GetCagesByStaffEmail(staffEmail);
>>>>>>> b665f52de90c177e31ef6f5b7cbd0cd0827c5612
    }
}

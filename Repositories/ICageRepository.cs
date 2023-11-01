using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICageRepository
    {
        IEnumerable<Cage> GetCages();

        Cage GetCageById(int id);
        void DeleteCage(int id);
        void UpdateCage(Cage cage);
        void InsertCage(Cage cage);

        List<Cage> GetCagesByStaffEmail(String staffEmail);
        List<Cage> GetCagesByExpertEmail(String expertEmail);

    }
}

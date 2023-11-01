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
<<<<<<< HEAD
        List<Cage> GetCagesByExpertEmail(String expertEmail);
=======
>>>>>>> 4cc1e79d88277d7bf274d2208cf382a8007c5ee9

    }
}

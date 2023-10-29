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
<<<<<<< HEAD

        Cage GetCageById(int id);
        void DeleteCage(int id);
        void UpdateCage(Cage cage);
        void InsertCage(Cage cage);
=======
        List<Cage> GetCagesByStaffEmail(String staffEmail);
>>>>>>> b665f52de90c177e31ef6f5b7cbd0cd0827c5612
    }
}

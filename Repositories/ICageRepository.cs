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
        List<Cage> GetCagesByStaffEmail(String staffEmail);
        List<Cage> GetCagesByExpertEmail(String expertEmail);

    }
}

using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAreaRepository
    {
        IEnumerable<Area> GetAreas();
        Area GetAreaByID(int areaID);
    }
}

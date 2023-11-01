using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AreaRepostitory : IAreaRepository
    {
        public Area GetAreaByID(int areaID) => AreaDAO.Instance.GetAreaByID(areaID);
       

        public IEnumerable<Area> GetAreas() => AreaDAO.Instance.GetAreas();
    }
}

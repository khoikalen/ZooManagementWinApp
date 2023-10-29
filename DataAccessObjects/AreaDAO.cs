using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AreaDAO
    {
        private static AreaDAO instance;
        private static readonly object instanceLock = new object();
        private AreaDAO() { }
        public static AreaDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AreaDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Area> GetAreas()
        {
            var areas = new List<Area>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                areas = db.Areas.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return areas;
        }
    }
}

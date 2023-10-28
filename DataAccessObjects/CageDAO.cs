using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CageDAO
    {
        private static CageDAO instance = null;
        private static readonly object instanceLock = new object();
        private CageDAO() { }
        public static CageDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CageDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Cage> GetCages()
        {
            var cages = new List<Cage>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                cages = db.Cages.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cages;
        }
    }
}

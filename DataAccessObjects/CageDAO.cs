using BusinessObjects.Models;
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


        public Cage GetCageById(int id)
        {
            var cage = new Cage();
            try
            {
                using var db = new ZooManagementDotNetContext();
                cage = db.Cages.SingleOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cage;
        }
        
        public void InsertCage(Cage cage)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.Cages.Add(cage);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateCage(Cage cage)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.Cages.Update(cage);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCage(int id)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.Cages.Remove(GetCageById(id));
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Cage> GetCagesByStaffEmail(String staffEmail)
        {
            using(var context = new ZooManagementDotNetContext())
            {
                var cages = from cage in context.Cages
                            join staff in context.staff on cage.StaffId equals staff.Id
                            where staff.Email.Equals(staffEmail)
                            select cage;
                return cages.ToList();
            }
        }


        public List<Cage> GetCagesByExpertEmail(String expertEmail)
        {
            var cage = new List<Cage>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                Expert expert = db.Experts.SingleOrDefault(a=> a.Email == expertEmail);
                cage = db.Cages.Where(a => a.AreaId == expert.AreaId).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return cage;
        }

    }
}

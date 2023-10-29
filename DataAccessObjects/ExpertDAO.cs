using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ExpertDAO
    {
        private static ExpertDAO instance = null;
        private static readonly object instanceLock = new object();
        private ExpertDAO() { }
        public static ExpertDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ExpertDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Expert> GetExperts()
        {
            var experts = new List<Expert>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                experts = db.Experts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return experts;
        }

        public Expert GetExpertById(int id)
        {
            var expert = new Expert();
            try
            {
                using var db = new ZooManagementDotNetContext();
                expert = db.Experts.SingleOrDefault(e => e.Id == id);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            return expert;
        }

        public void InsertExpert(Expert expert)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.Experts.Add(expert);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateExpert(Expert expert)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.Experts.Update(expert);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteExpert(int id)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.Experts.Remove(GetExpertById(id));
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

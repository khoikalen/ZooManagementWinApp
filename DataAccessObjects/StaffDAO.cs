using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class StaffDAO
    {
        private static StaffDAO instance = null;
        private static readonly object instanceLock = new object();
        private StaffDAO() { }
        public static StaffDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }

        public List<staff> GetStaffs()
        {
            var staffs = new List<staff>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                staffs = db.staff.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staffs;
        }

        public staff GetStaffByEmail(String staffEmail)
        {
            var staff = new staff();
            try
            {
                using var db = new ZooManagementDotNetContext();
                staff = db.staff.SingleOrDefault(s => s.Email.Equals(staffEmail));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staff;
        }

        public staff GetStaffById(int staffID)
        {
            var staff = new staff();
            try
            {
                using var db = new ZooManagementDotNetContext();
                staff = db.staff.SingleOrDefault(s => s.Id == staffID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staff;
        }

        public void InsertStaff(staff staff)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.staff.Add(staff);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void UpdateStaff(staff staff)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.staff.Update(staff);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void DeleteStaff(int id)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.staff.Remove(GetStaffById(id));
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

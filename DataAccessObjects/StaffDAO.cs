﻿using BusinessObjects;
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
                using var db = new ZooManagement_DotNetContext();
                staffs = db.staff.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staffs;
        }

        public staff GetStaffById(int id)
        {
            var staff = new staff();
            try
            {
                using var db = new ZooManagement_DotNetContext();
                staff = db.staff.SingleOrDefault(s => s.Id == id);
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
                using var db = new ZooManagement_DotNetContext();
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
                using var db = new ZooManagement_DotNetContext();
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
                using var db = new ZooManagement_DotNetContext();
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
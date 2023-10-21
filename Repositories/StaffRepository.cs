﻿using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StaffRepository : IStaffRepository
    {
        public void DeleteStaffs(int id) => StaffDAO.Instance.DeleteStaff(id);

        public staff GetStaffById(int id) => StaffDAO.Instance.GetStaffById(id);

        public IEnumerable<staff> GetStaffs() => StaffDAO.Instance.GetStaffs();

        public void InsertStaff(staff staff) => StaffDAO.Instance.InsertStaff(staff);

        public void UpdateStaff(staff staff) => StaffDAO.Instance.UpdateStaff(staff);
    }
}

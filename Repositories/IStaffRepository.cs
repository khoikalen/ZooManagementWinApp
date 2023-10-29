using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IStaffRepository
    {
        IEnumerable<staff> GetStaffs();
        staff GetStaffByEmail(String staffEmail);
        staff GetStaffById(int staffID);
        void DeleteStaffs(int id);
        void UpdateStaff(staff staff);
        void InsertStaff(staff staff);
    }
}

using BusinessObjects.Dtos;
using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class LogRepository : ILogRepository
    {
        public void CreateLog(AnimalLog log) => LogDAO.Instance.CreateLog(log);
        public List<HealthLogResponse> GetLog(string email) => LogDAO.Instance.GetHealLog(email);
        
    }
}

﻿using BusinessObjects.Dtos;
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
        public List<HealthLogResponse> GetLog(string email) => LogDAO.Instance.GetHealLog(email);
        
    }
}
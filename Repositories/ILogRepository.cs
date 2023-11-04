using BusinessObjects.Dtos;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ILogRepository
    {
        List<HealthLogResponse> GetLog(String email);
        void CreateLog(AnimalLog log);
        List<HealthLogResponse> GetHealthLogs(String email);
        List<HealthLogResponse> GetHealthLogsBySpecies(string species,string email);


    }
}

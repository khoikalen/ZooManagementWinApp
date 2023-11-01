using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Dtos;
using BusinessObjects.Models;

namespace DataAccessObjects
{
    public class LogDAO
    {
        private static LogDAO instance = null;
        private static readonly object instanceLock = new object();

        private LogDAO() { }
        public static LogDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new LogDAO();
                    }
                }
                return instance;
            }
        }

        public List<HealthLogResponse> GetHealLog(String email)
        {
            var listHealthLog = new List<HealthLogResponse>();
            List<Animal> animals = new List<Animal>();
            List<AnimalLog> logs = new List<AnimalLog>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                Expert expert = db.Experts.SingleOrDefault(a => a.Email==email);
                List<Cage> cages = db.Cages.Where(a => a.AreaId==expert.AreaId).ToList();
                foreach(var cage in cages)
                {
                    animals.AddRange(db.Animals.Where(a => a.CageId == cage.Id));
                }

                foreach(var animal in animals)
                {
                    logs.AddRange(db.AnimalLogs.Where(a=>a.AnimalId== animal.Id));
                }

                foreach(var log in logs)
                {
                    Animal animal = db.Animals.SingleOrDefault(a => a.Id== log.AnimalId);
                    HealthLogResponse healthLogResponse = new HealthLogResponse() {
                                                                Type = log.Type,
                                                                ShortDescription = log.ShortDescription,
                                                                DateTime = (DateTime)log.DateTime,
                                                                AnimalName=animal.Name,
                                                                Species=animal.Specie
                    };
                    listHealthLog.Add(healthLogResponse);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listHealthLog.OrderByDescending(a=>a.DateTime).ToList();
        }


        public void CreateLog(AnimalLog log )
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.AnimalLogs.Add(log);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<AnimalLog> ViewLog(int animalId)
        {
            var list = new List<AnimalLog>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                list = db.AnimalLogs.Where(a=>a.AnimalId==animalId).ToList();   

            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

    }





}

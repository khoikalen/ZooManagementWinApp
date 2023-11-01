using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AnimalDAO
    {
        private static AnimalDAO instance = null;
        private static readonly object instanceLock;
        private AnimalDAO() { }
        public static AnimalDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnimalDAO();
                }
                return instance;
            }
        }

        /*public IEnumerable<Animal> getAllAnimalUnderStaffControll()
        {
            List<Animal> list = new List<Animal>();
            using(var context = new ZooManagementDotNetContext())
            {
                context.Animals.Find()
            }
        }*/

        public void DeleteAnimal(Animal animal)
        {
            using (var context = new ZooManagementDotNetContext())
            {
                context.Animals.Remove(animal);
                context.SaveChanges();
            }
        }
        public void UpdateAnimalStatusToDead(int animalID)
        {
            using (var context = new ZooManagementDotNetContext())
            {
                Animal animal = context.Animals.FirstOrDefault(c => c.Id == animalID);
                animal.Status = "Dead";
                context.SaveChanges();
            }
        }
        public void UpdateAnimalInformation(Animal animal)
        {
            using (var context = new ZooManagementDotNetContext())
            {
                context.Animals.Update(animal);
                context.SaveChanges();
            }
        }
        public Animal SearchAnimalByID(int animalID)
        {
            using(var context = new ZooManagementDotNetContext())
            {
                return context.Animals.SingleOrDefault(c => c.Id == animalID);
            }
        }
        public List<Animal> GetAnimalByCageID(int cageID)
        {
            using(var context = new ZooManagementDotNetContext())
            {
                var animalList = context.Animals.Where(c => c.CageId == cageID);
                return animalList.ToList();
            }
        }
        public String GetAnimalSpecie(int cageID)
        {
            using(var context = new ZooManagementDotNetContext())
            {
                var animalSpecie = context.Animals.FirstOrDefault(c => c.CageId.Equals(cageID));
                return animalSpecie.Specie;
            }
        }
        public List<Animal> SearchListAnimalByCageID(int cageID)
        {
            using (var context = new ZooManagementDotNetContext())
            {
                return context.Animals.Where(a=>a.CageId==cageID).ToList();
            }
        }
        public void CreateNewAnimal(Animal animal)
        {
            using(var context = new ZooManagementDotNetContext())
            {
                context.Add(animal);
                context.SaveChanges();
            }
        }
        public IEnumerable<Animal> GetAllAnimals()
        {
            using(var context = new ZooManagementDotNetContext())
            {
                List<Animal> animals = context.Animals.ToList();
                return animals;
            }
        }
        public int AnimalQuantityInCage(int cageID)
        {
            using(var context = new ZooManagementDotNetContext())
            {
                return context.Animals.Count(c =>  c.CageId == cageID);
            }
        }
    }
}

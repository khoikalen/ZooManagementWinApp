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
        public void DeleteAnimal(int animalID)
        {
            using(var context = new ZooManagementDotNetContext())
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
        public Animal SearchAnimalByCageID(int cageID)
        {
            using(var context = new ZooManagementDotNetContext())
            {
                return context.Animals.SingleOrDefault(c => c.Id == (cageID));
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
    }
}

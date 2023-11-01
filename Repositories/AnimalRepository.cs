using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        public int AnimalQuantityInCage(int cageID) => AnimalDAO.Instance.AnimalQuantityInCage(cageID);

        public void CreateNewAnimal(Animal animal) => AnimalDAO.Instance.CreateNewAnimal(animal);

        public void DeleteAnimal(Animal animal) => AnimalDAO.Instance.DeleteAnimal(animal);

        public IEnumerable<Animal> GetAllAnimals() => AnimalDAO.Instance.GetAllAnimals();

        public IEnumerable<Animal> GetAllAnimalsByCageID(int cageID) => AnimalDAO.Instance.SearchListAnimalByCageID(cageID);
       
        public List<Animal> GetAnimalByCageID(int cageID) => AnimalDAO.Instance.GetAnimalByCageID(cageID);

        public string GetAnimalSpecie(int cageID) => AnimalDAO.Instance.GetAnimalSpecie(cageID);


        public List<Animal> SearchAnimalByCageID(int cageID) => AnimalDAO.Instance.SearchListAnimalByCageID(cageID);
        

        public Animal SearchAnimalByID(int animalID) => AnimalDAO.Instance.SearchAnimalByID(animalID);
       

        public void UpdateAnimalInformation(Animal animal) => AnimalDAO.Instance.UpdateAnimalInformation(animal);

        public void UpdateAnimalStatusToDead(int animalID) => AnimalDAO.Instance.UpdateAnimalStatusToDead(animalID);
    }
}

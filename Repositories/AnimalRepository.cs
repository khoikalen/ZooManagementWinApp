using BusinessObjects;
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
        public void CreateNewAnimal(Animal animal) => AnimalDAO.Instance.CreateNewAnimal(animal);
       

        public void DeleteAnimal(int animalID) => AnimalDAO.Instance.DeleteAnimal(animalID);

        public IEnumerable<Animal> GetAllAnimals() => AnimalDAO.Instance.GetAllAnimals();
       
        public Animal SearchAnimalByCageID(int cageID) => AnimalDAO.Instance.SearchAnimalByCageID(cageID);
        

        public Animal SearchAnimalByID(int animalID) => AnimalDAO.Instance.SearchAnimalByID(animalID);
       

        public void UpdateAnimalInformation(Animal animal) => AnimalDAO.Instance.UpdateAnimalInformation(animal);
       
    }
}

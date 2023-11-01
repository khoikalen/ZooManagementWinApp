using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAnimalRepository
    {
        void DeleteAnimal(Animal animal);
        void UpdateAnimalStatusToDead(int animalID);
        void UpdateAnimalInformation(Animal animal);
        Animal SearchAnimalByID(int animalID);
        List<Animal> GetAnimalByCageID(int cageID);
        void CreateNewAnimal(Animal animal);
        IEnumerable<Animal> GetAllAnimals();
        public String GetAnimalSpecie(int cageID);
        int AnimalQuantityInCage(int cageID);

        IEnumerable<Animal> GetAllAnimalsByCageID(int cageID);
    }
}

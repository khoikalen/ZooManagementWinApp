using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAnimalRepository
    {
        void DeleteAnimal(int animalID);
        void UpdateAnimalInformation(Animal animal);
        Animal SearchAnimalByID(int animalID);
        Animal SearchAnimalByCageID(int cageID);
        void CreateNewAnimal(Animal animal);
        IEnumerable<Animal> GetAllAnimals();
    }
}

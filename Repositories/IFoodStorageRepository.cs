using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFoodStorageRepository
    {
        public IEnumerable<FoodStorage> GetFoodStorageByType(string type);
        public FoodStorage GetFoodInStorageById(int id);
        public FoodStorage GetFoodInStorageByName(string name);


        public void InsertFood(FoodStorage food);
        public void UpdateFood(FoodStorage food);
        public void DeleteFood(int id); 
        public IEnumerable<FoodStorage> GetAllFoodStorage();
        //public List<String> GetAllFoodStorageType();

    }
}

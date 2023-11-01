using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FoodStorageRepository : IFoodStorageRepository
    {
        

          
        public void DeleteFood(int id) => FoodStorageDAO.Instance.DeleteFood(id);
        public FoodStorage GetFoodInStorageById(int id) => FoodStorageDAO.Instance.GetFoodInStorageById(id);


        public IEnumerable<FoodStorage> GetAllFoodStorage() => FoodStorageDAO.Instance.GetFoodStorage();

        //public List<String> GetAllFoodStorageType() => FoodStorageDAO.Instance.GetFoodStorageType();
        

        public IEnumerable<FoodStorage> GetFoodStorageByType(string type) => FoodStorageDAO.Instance.GetListFoodByType(type);
       

        public void InsertFood(FoodStorage food) => FoodStorageDAO.Instance.AddNewFood(food);
       

        public void UpdateFood(FoodStorage food) => FoodStorageDAO.Instance.UpdateFood(food);
       
    }
}

using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FoodInMealRepository : IFoodInMealRepository
    {
        public void AddInMeal(FoodInMeal foodInMeal) => FoodInMealDAO.Instance.AddFoodInMeal(foodInMeal);

        public void DelInMeal(int foodId) => FoodInMealDAO.Instance.DeleteFoodInMeal(foodId);
      
    }
}

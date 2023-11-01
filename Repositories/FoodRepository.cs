using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FoodRepository : IFoodRepository
    {
        public IEnumerable<Food> GetAllFood() => FoodDAO.Instance.GetAllFoods();
        
        public void InsertFood(Food food) => FoodDAO.Instance.InsertFood(food);
        public List<Food> GetFoodByMealId(int mealId) => FoodDAO.Instance.GetFoodsInMeal(mealId);

        public void UpdateFood(Food food) => FoodDAO.Instance.UpdateFood(food);

        public void DeleteFood(int id) => FoodDAO.Instance.DeleteFood(id);

        public Food GetFoodById(int id) => FoodDAO.Instance.GetFoodsById(id);
        
    }
}

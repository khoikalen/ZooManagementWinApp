using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFoodRepository
    {
        public List<Food> GetFoodByMealId(int mealId);
        public Food GetFoodById(int id);

        public void InsertFood(Food food);
        public IEnumerable<Food> GetAllFood();
        public void UpdateFood(Food food);
        public void DeleteFood(int id);
    }
}

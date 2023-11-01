using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        private static readonly object lockInstance = new object();
        private FoodDAO() { }
        public static FoodDAO Instance
        {
            get
            {
                lock(lockInstance)
                {
                    if(instance == null)
                    {
                        instance = new FoodDAO();
                    }
                }
                return instance;
            }
        }


        public List<Food> GetFoodsInMeal(int mealId)
        {
            var listFood = new List<Food>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                listFood = db.Foods.Join(db.FoodInMeals, food=> 
                food.Id,foodInMeal => foodInMeal.FoodId,(food,foodInMeal)=>new {Food=food,FoodInMeal=foodInMeal} )
               .Where(joinResult => joinResult.FoodInMeal.MealId== mealId)
               .Select(joinResult=>joinResult.Food).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listFood;
        }


        public Food GetFoodsById(int id)
        {
            var food = new Food();
            try
            {
                using var db = new ZooManagementDotNetContext();
                food = db.Foods.SingleOrDefault(a=>a.Id==id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return food;
        }

        public List<Food> GetAllFoods()
        {
            var listFood = new List<Food>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                listFood = db.Foods.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return listFood;
        }

        public void InsertFood(Food food)
        {
            try
            {
                
                using var db =new ZooManagementDotNetContext();
                db.Foods.Add(food);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateFood(Food food) {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.Foods.Update(food);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteFood(int id) {
            try
            {
                using var db = new ZooManagementDotNetContext();
                var food = db.Foods.SingleOrDefault(a => a.Id == id);
                db.Foods.Remove(food);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

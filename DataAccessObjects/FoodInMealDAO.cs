using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class FoodInMealDAO
    {
        private static FoodInMealDAO instance=null;
        private static readonly object lockInstance = new object();
        private FoodInMealDAO() { }
        public static FoodInMealDAO Instance
        {
            get
            {
                lock(lockInstance)
                {
                    if (instance == null)
                    {
                        instance = new FoodInMealDAO();
                    }
                }
                return instance;
            }
        }

        public void AddFoodInMeal(FoodInMeal foodInMeal)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.FoodInMeals.Add(foodInMeal);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteFoodInMeal(int foodId)
        {
            try
            {   
                
                using var db = new ZooManagementDotNetContext();
                var food = db.FoodInMeals.SingleOrDefault(a=>a.FoodId== foodId);
                db.FoodInMeals.Remove(food);
                db.SaveChanges() ;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

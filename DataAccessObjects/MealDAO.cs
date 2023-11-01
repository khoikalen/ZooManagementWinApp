using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MealDAO
    {
        private static MealDAO instance = null;
        private static readonly object lockInstance = new object();
        private MealDAO() { }
        public static MealDAO Instance
        {
            get
            {
                lock(lockInstance)
                {
                    if (instance == null)
                    {
                        instance = new MealDAO();
                    }
                }
                return instance;
            }
            
        }



        public Meal FindMealByAnimalId(int animalId)
        {
            var meals = new Meal();
            try
            {
                using var db = new ZooManagementDotNetContext();
                meals = db.Meals.SingleOrDefault(a=>a.AnimalId==animalId);
            }
            catch (Exception)
            {

                throw;
            }
            return meals;
        }

        public void InsertMeal(Meal meal)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                
                db.Meals.Add(meal);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

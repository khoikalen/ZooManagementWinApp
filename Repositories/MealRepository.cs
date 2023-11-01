using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MealRepository : IMealRepository
    {
        public void Add(Meal meal) => MealDAO.Instance.InsertMeal(meal);
       

        public Meal GetMealByAnimalId(int animalId) => MealDAO.Instance.FindMealByAnimalId(animalId);
        
    }
}

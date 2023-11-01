using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMealRepository
    {
        public void Add(Meal meal);
        public Meal GetMealByAnimalId(int animalId);
    }
}

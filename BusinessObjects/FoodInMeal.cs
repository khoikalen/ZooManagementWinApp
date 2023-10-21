using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class FoodInMeal
    {
        public int? MealId { get; set; }
        public int? FoodId { get; set; }

        public virtual Food Food { get; set; }
        public virtual Meal Meal { get; set; }
    }
}

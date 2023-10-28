using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AnimalId { get; set; }

        public virtual Animal Animal { get; set; }
    }
}

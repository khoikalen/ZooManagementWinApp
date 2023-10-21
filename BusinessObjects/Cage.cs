using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Cage
    {
        public Cage()
        {
            AnimalSpecies = new HashSet<AnimalSpecie>();
            Animals = new HashSet<Animal>();
            Meals = new HashSet<Meal>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public string CageStatus { get; set; }
        public string CageType { get; set; }
        public int? AreaId { get; set; }
        public int? StaffId { get; set; }

        public virtual Area Area { get; set; }
        public virtual staff Staff { get; set; }
        public virtual ICollection<AnimalSpecie> AnimalSpecies { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}

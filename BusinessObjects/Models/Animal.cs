using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class Animal
    {
        public Animal()
        {
            AnimalLogs = new HashSet<AnimalLog>();
            Meals = new HashSet<Meal>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Dez { get; set; }
        public string Gender { get; set; }
        public string Specie { get; set; }
        public string Status { get; set; }
        public int? CageId { get; set; }

        public virtual Cage Cage { get; set; }
        public virtual ICollection<AnimalLog> AnimalLogs { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class Cage
    {
        public Cage()
        {
            Animals = new HashSet<Animal>();
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
        public virtual ICollection<Animal> Animals { get; set; }
    }
}

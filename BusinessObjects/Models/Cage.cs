using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "Cage Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        public int? Quantity { get; set; }
        [Required(ErrorMessage = "Cage Status is required")]
        public string CageStatus { get; set; }
        public string CageType { get; set; }
        [Required(ErrorMessage = "Area ID is required")]
        public int AreaId { get; set; }
        public int StaffId { get; set; }

        public virtual Area Area { get; set; }
        public virtual staff Staff { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}

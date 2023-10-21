using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class AnimalSpecie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public int? CageId { get; set; }

        public virtual Cage Cage { get; set; }
    }
}

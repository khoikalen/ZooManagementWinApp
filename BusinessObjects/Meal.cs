using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CageId { get; set; }

        public virtual Cage Cage { get; set; }
    }
}

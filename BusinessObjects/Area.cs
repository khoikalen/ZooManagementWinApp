using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Area
    {
        public Area()
        {
            Cages = new HashSet<Cage>();
            Experts = new HashSet<Expert>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cage> Cages { get; set; }
        public virtual ICollection<Expert> Experts { get; set; }
    }
}

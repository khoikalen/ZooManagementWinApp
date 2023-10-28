using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class AnimalLog
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime? DateTime { get; set; }
        public string ShortDescription { get; set; }
        public int? AnimalId { get; set; }

        public virtual Animal Animal { get; set; }
    }
}

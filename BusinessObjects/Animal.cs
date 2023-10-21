using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Animal
    {
        public Animal()
        {
            LogTypes = new HashSet<LogType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Dez { get; set; }
        public string Sex { get; set; }
        public string Specie { get; set; }
        public string Status { get; set; }
        public int? CageId { get; set; }

        public virtual Cage Cage { get; set; }
        public virtual ICollection<LogType> LogTypes { get; set; }
    }
}

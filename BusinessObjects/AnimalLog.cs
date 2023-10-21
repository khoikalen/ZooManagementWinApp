using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class AnimalLog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateTime { get; set; }
        public int? LogtypeId { get; set; }

        public virtual LogType Logtype { get; set; }
    }
}

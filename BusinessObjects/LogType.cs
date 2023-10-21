using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class LogType
    {
        public LogType()
        {
            AnimalLogs = new HashSet<AnimalLog>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? AnimalId { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual ICollection<AnimalLog> AnimalLogs { get; set; }
    }
}

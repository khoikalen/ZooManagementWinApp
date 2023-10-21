using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class staff
    {
        public staff()
        {
            Cages = new HashSet<Cage>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime? StartDay { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Cage> Cages { get; set; }
    }
}

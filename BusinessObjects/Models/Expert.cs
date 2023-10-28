using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class Expert
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? StartDay { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int? AreaId { get; set; }

        public virtual Area Area { get; set; }
    }
}

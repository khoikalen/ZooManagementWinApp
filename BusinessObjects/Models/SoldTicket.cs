using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class SoldTicket
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Date { get; set; }
    }
}

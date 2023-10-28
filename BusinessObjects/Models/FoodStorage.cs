using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class FoodStorage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double? Available { get; set; }
    }
}

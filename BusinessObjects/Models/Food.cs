using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Weight { get; set; }
    }
}

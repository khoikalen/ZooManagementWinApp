using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}

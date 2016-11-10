using System;
using System.Collections.Generic;

namespace KAB.Models.Entities
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}

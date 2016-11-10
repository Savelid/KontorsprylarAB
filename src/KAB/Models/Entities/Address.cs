using System;
using System.Collections.Generic;

namespace KAB.Models.Entities
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}

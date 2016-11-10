using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KAB.Models
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}

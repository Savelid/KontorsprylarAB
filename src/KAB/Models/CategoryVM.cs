using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KAB.Models
{
    public class CategoryVM
    {
        public string CategoryName { get; set; }
        public List<CategoryVM> SubCategories { get; set; }
        public List<ProductVM> Products { get; set; }
    }
}

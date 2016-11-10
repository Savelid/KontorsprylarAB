using System;
using System.Collections.Generic;

namespace KAB.Models.Entities
{
    public partial class CategoryCategories
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Categories SubCategory { get; set; }
    }
}

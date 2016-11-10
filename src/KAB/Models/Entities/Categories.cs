using System;
using System.Collections.Generic;

namespace KAB.Models.Entities
{
    public partial class Categories
    {
        public Categories()
        {
            CategoriesProducts = new HashSet<CategoriesProducts>();
            CategoryCategoriesCategory = new HashSet<CategoryCategories>();
            CategoryCategoriesSubCategory = new HashSet<CategoryCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTopCategory { get; set; }

        public virtual ICollection<CategoriesProducts> CategoriesProducts { get; set; }
        public virtual ICollection<CategoryCategories> CategoryCategoriesCategory { get; set; }
        public virtual ICollection<CategoryCategories> CategoryCategoriesSubCategory { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace KAB.Models.Entities
{
    public partial class CategoriesProducts
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Product Product { get; set; }
    }
}

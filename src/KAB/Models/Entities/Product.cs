using System;
using System.Collections.Generic;

namespace KAB.Models.Entities
{
    public partial class Product
    {
        public Product()
        {
            CategoriesProducts = new HashSet<CategoriesProducts>();
            OrderRow = new HashSet<OrderRow>();
            StockStatus = new HashSet<StockStatus>();
        }

        public int Id { get; set; }
        public string Articlenumber { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CategoriesProducts> CategoriesProducts { get; set; }
        public virtual ICollection<OrderRow> OrderRow { get; set; }
        public virtual ICollection<StockStatus> StockStatus { get; set; }
    }
}

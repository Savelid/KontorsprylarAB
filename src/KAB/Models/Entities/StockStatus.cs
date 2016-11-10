using System;
using System.Collections.Generic;

namespace KAB.Models.Entities
{
    public partial class StockStatus
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int Status { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace KAB.Models.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderRow = new HashSet<OrderRow>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }

        public virtual ICollection<OrderRow> OrderRow { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

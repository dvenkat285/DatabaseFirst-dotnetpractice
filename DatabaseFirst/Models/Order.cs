using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ProductCode { get; set; } = null!;
        public decimal? Quantity { get; set; }
    }
}

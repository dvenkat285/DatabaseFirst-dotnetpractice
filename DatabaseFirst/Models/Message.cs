using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Message
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? ProductCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}

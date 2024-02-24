using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Oreders21
    {
        public int? Ordernumber { get; set; }
        public DateTime? Orderdate { get; set; }
        public DateTime? Requireddate { get; set; }
        public DateTime? Shippeddate { get; set; }
        public string? Status { get; set; }
        public int? Customerno { get; set; }
        public string? Comments { get; set; }
    }
}

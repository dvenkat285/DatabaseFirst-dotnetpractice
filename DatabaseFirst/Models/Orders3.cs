using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Orders3
    {
        public int? Orderid { get; set; }
        public byte? Customerid { get; set; }
        public DateTime? Orderdate { get; set; }
    }
}

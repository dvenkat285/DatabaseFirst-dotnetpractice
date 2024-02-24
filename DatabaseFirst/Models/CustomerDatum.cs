using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class CustomerDatum
    {
        public int CustId { get; set; }
        public string? CustName { get; set; }
        public long? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}

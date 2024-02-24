using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Customer
    {
        public string? CustCode { get; set; }
        public string? CustName { get; set; }
        public string? CustCity { get; set; }
        public string? CustCountry { get; set; }
        public string? Grade { get; set; }
        public double? OpeningAmount { get; set; }
        public double? ReceiveAmt { get; set; }
        public double? PaymentAmt { get; set; }
        public double? OutstandingAmt { get; set; }
        public long? PhoneNo { get; set; }
        public string? AgentCode { get; set; }
    }
}

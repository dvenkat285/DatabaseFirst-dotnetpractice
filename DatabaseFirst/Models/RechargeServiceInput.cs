using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class RechargeServiceInput
    {
        public int Rsid { get; set; }
        public string UniqueServiceNumber { get; set; } = null!;
        public int RechargeAmount { get; set; }
        public int TransactionNumber { get; set; }
        public string TransactionDate { get; set; } = null!;
        public DateTimeOffset Sts { get; set; }
    }
}

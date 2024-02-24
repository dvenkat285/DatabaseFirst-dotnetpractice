using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class TmmsDashboard
    {
        public string? Rtc { get; set; }
        public DateTimeOffset Sts { get; set; }
        public int? Meterid { get; set; }
        public string? OilLevel { get; set; }
        public decimal? L1voltageVrn { get; set; }
        public decimal? L1signedPowerFactorRphase { get; set; }
        public decimal? Frequency { get; set; }
    }
}

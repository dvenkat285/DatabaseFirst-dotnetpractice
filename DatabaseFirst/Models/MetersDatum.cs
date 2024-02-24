using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class MetersDatum
    {
        public string? DcSno { get; set; }
        public bool? VlookDcstatus { get; set; }
        public string ServiceNo { get; set; } = null!;
        public double? PhaseCurrent { get; set; }
        public double? NeutralCurrent { get; set; }
        public double? Voltage { get; set; }
        public double? PowerFactor { get; set; }
        public double? Frequency { get; set; }
        public double? MeterReadingKWh { get; set; }
        public double? MeterReadingKVah { get; set; }
        public double? MdKW { get; set; }
        public string? MdKWTs { get; set; }
        public double? MdKVa { get; set; }
        public string? MdKVaTs { get; set; }
        public string? EventStatus { get; set; }
        public DateTime? DateTime { get; set; }
    }
}

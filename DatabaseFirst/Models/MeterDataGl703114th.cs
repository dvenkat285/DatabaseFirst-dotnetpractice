using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class MeterDataGl703114th
    {
        public string? DcSno { get; set; }
        public string? ServiceNo { get; set; }
        public string? Msn { get; set; }
        public string? PhysicalAddress { get; set; }
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
        public string? DateTime { get; set; }
        public byte? Ranks1 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class MasterList
    {
        public string? Dcsno { get; set; }
        public string? DcboxNo { get; set; }
        public string ServiceNo { get; set; } = null!;
        public string? MeterSno { get; set; }
        public string? Dtsno { get; set; }
        public string? PhysicalAddress { get; set; }
        public string? StatusDescription { get; set; }
    }
}

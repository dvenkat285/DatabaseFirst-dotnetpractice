using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Bi1
    {
        public int StructureCode { get; set; }
        public int TransformerSno { get; set; }
        public int DeviceSno { get; set; }
        public string DeviceIp { get; set; } = null!;
        public DateTimeOffset NwIntStart { get; set; }
        public DateTimeOffset NwIntEnd { get; set; }
        public string? Duration { get; set; }
        public TimeSpan? Timee { get; set; }
        public int? Timee1 { get; set; }
    }
}

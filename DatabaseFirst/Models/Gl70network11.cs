using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Gl70network11
    {
        public int StructureCode { get; set; }
        public int TransformerSno { get; set; }
        public int DeviceSerialNo { get; set; }
        public string DeviceIp { get; set; } = null!;
        public DateTimeOffset NwIntStart { get; set; }
        public DateTimeOffset NwIntEnd { get; set; }
        public DateTimeOffset? TimeDiffSec { get; set; }
        public DateTimeOffset Sts { get; set; }
        public string? Duration { get; set; }
    }
}

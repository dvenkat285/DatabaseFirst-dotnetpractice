using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Bi
    {
        public int StructureCode { get; set; }
        public int TransformerSno { get; set; }
        public int DeviceSno { get; set; }
        public string DeviceIp { get; set; } = null!;
        public DateTime NwIntStart { get; set; }
        public DateTime NwIntEnd { get; set; }
        public TimeSpan? DurationTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Bi2
    {
        public int StructureCode { get; set; }
        public int TransformerSno { get; set; }
        public int DeviceSno { get; set; }
        public string DeviceIp { get; set; } = null!;
        public string NwIntStart { get; set; } = null!;
        public string NwIntEnd { get; set; } = null!;
        public TimeSpan? Timee { get; set; }
    }
}

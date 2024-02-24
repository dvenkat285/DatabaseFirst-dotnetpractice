using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EficaaBi
    {
        public string StructureCode { get; set; } = null!;
        public string Transformersno { get; set; } = null!;
        public string DeviceSerialNo { get; set; } = null!;
        public string DeviceIp { get; set; } = null!;
        public DateTimeOffset NwIntStart { get; set; }
        public DateTimeOffset NwIntEnd { get; set; }
        public DateTimeOffset Sts { get; set; }
        public int Duration { get; set; }
        public string? ConvertedToDHhMmSsMs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class VwNm
    {
        public string? DeviceSerialNo { get; set; }
        public string? DeviceIp { get; set; }
        public string? DeviceName { get; set; }
        public string TransformerSno { get; set; } = null!;
        public DateTimeOffset? NwIntStart { get; set; }
        public DateTimeOffset? NwIntEnd { get; set; }
        public int? NotInNetwork { get; set; }
        public int? InNetwork { get; set; }
        public int? Connected { get; set; }
        public int? Disconnected { get; set; }
        public int? IsActive { get; set; }
    }
}

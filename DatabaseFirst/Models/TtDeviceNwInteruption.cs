using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class TtDeviceNwInteruption
    {
        public int TtId { get; set; }
        public int DeviceId { get; set; }
        public string? DeviceIp { get; set; }
        public DateTimeOffset? NwIntStart { get; set; }
        public DateTimeOffset? NwIntEnd { get; set; }
        public DateTimeOffset? Sts { get; set; }

        public virtual EtDeviceDetail Device { get; set; } = null!;
    }
}

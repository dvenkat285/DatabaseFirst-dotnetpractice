using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class HtDeviceNwInteruption
    {
        public int HtId { get; set; }
        public int DeviceId { get; set; }
        public string? DeviceIp { get; set; }
        public DateTimeOffset? NwIntStart { get; set; }
        public DateTimeOffset? NwIntEnd { get; set; }
        public DateTimeOffset? Sts { get; set; }
    }
}

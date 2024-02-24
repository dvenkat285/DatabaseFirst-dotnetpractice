using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Requestoutbox
    {
        public double? RequestId { get; set; }
        public string? Cjid { get; set; }
        public string? PhysicalAddress { get; set; }
        public double? CommandId { get; set; }
        public double? DeviceId { get; set; }
        public string? RequestFrame { get; set; }
        public DateTime? RequestTs { get; set; }
        public double? IsProcessed { get; set; }
    }
}

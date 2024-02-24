using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Responseinbox
    {
        public double? ResponseId { get; set; }
        public string? Cjid { get; set; }
        public string? PhysicalAddress { get; set; }
        public string? ResponseFrame { get; set; }
        public DateTime? ResponseTs { get; set; }
        public double? IsProcessed { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtCircleDetail
    {
        public int EtCircleDetails { get; set; }
        public int CircleId { get; set; }
        public int? RegionId { get; set; }
        public string CircleName { get; set; } = null!;
        public string? InchargeName { get; set; }
        public string? InchargeContactNumber { get; set; }
        public string? Location { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public DateTimeOffset Crts { get; set; }
        public string? UserIp { get; set; }
        public int? InchargeUserid { get; set; }
        public bool IsActive { get; set; }
    }
}

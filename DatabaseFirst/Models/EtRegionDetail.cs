using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtRegionDetail
    {
        public int EtRegionId { get; set; }
        public int RegionId { get; set; }
        public string? RegionName { get; set; }
        public string? RegionCode { get; set; }
        public string? Districts { get; set; }
        public int? TotalConsumers { get; set; }
        public string? Location { get; set; }
        public string? InchargeName { get; set; }
        public string? InchargeContactNumber { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public DateTimeOffset? Crts { get; set; }
        public string? UserIp { get; set; }
        public int? InchargeUserid { get; set; }
        public bool? IsActive { get; set; }
    }
}

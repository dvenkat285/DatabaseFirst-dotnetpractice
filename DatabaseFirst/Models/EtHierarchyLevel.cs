using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtHierarchyLevel
    {
        public int EtHierarchyLevelId { get; set; }
        public string? LevelType { get; set; }
        public string? LevelName { get; set; }
        public int? LevelId { get; set; }
        public string? InchargeName { get; set; }
        public long? InchargeContactNumber { get; set; }
        public string? EmailId { get; set; }
        public string? Location { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset Sts { get; set; }
    }
}

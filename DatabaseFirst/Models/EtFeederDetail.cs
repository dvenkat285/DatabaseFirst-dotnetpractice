using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtFeederDetail
    {
        public EtFeederDetail()
        {
            EtDtrDetails = new HashSet<EtDtrDetail>();
        }

        public int EtFeederId { get; set; }
        public int FeederId { get; set; }
        public string FeederName { get; set; } = null!;
        public int SubstationId { get; set; }
        public string? InchargeName { get; set; }
        public string? InchargeContactNumber { get; set; }
        public string? FeederType { get; set; }
        public string? Location { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? UserIp { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual EtSubstationDetail Substation { get; set; } = null!;
        public virtual ICollection<EtDtrDetail> EtDtrDetails { get; set; }
    }
}

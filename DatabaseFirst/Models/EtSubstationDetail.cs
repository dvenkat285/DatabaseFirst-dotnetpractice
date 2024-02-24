using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtSubstationDetail
    {
        public EtSubstationDetail()
        {
            EtFeederDetails = new HashSet<EtFeederDetail>();
        }

        public int EtSubstationId { get; set; }
        public int SubstationId { get; set; }
        public string SubstationName { get; set; } = null!;
        public int SectionId { get; set; }
        public string? InchargeName { get; set; }
        public string? InchargeContactNumber { get; set; }
        public string? Location { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? UserIp { get; set; }
        public DateTimeOffset Crts { get; set; }
        public int? InchargeUserid { get; set; }
        public bool? IsActive { get; set; }

        public virtual EtSectionDetail Section { get; set; } = null!;
        public virtual ICollection<EtFeederDetail> EtFeederDetails { get; set; }
    }
}

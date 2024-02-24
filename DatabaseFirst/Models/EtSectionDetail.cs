using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtSectionDetail
    {
        public EtSectionDetail()
        {
            EtSubstationDetails = new HashSet<EtSubstationDetail>();
        }

        public int EtSectionId { get; set; }
        public int SectionId { get; set; }
        public string SectionName { get; set; } = null!;
        public string? Location { get; set; }
        public int? DivisionId { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string InchargeName { get; set; } = null!;
        public string? InchargeMobileNumber { get; set; }
        public int? InchargeUserid { get; set; }
        public string? UserIp { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual EtDivisionDetail? Division { get; set; }
        public virtual ICollection<EtSubstationDetail> EtSubstationDetails { get; set; }
    }
}

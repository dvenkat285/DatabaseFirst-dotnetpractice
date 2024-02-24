using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtDivisionDetail
    {
        public EtDivisionDetail()
        {
            EtSectionDetails = new HashSet<EtSectionDetail>();
        }

        public int EtDivisionId { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName { get; set; } = null!;
        public string? InchargeName { get; set; }
        public string? InchargeContactNumber { get; set; }
        public string? LocationName { get; set; }
        public int? CircleId { get; set; }
        public string? UserIp { get; set; }
        public int? InchargeUserid { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual ICollection<EtSectionDetail> EtSectionDetails { get; set; }
    }
}

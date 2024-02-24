using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtSimDetail
    {
        public EtSimDetail()
        {
            EtDcuDetails = new HashSet<EtDcuDetail>();
            EtMeterDetails = new HashSet<EtMeterDetail>();
        }

        public int SimId { get; set; }
        public string SimGsmno { get; set; } = null!;
        public string? UniqueSimno { get; set; }
        public int? NopId { get; set; }
        public string? SimIp { get; set; }
        public string? SimPlan { get; set; }
        public int? SimPort { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual EtNopDetail? Nop { get; set; }
        public virtual ICollection<EtDcuDetail> EtDcuDetails { get; set; }
        public virtual ICollection<EtMeterDetail> EtMeterDetails { get; set; }
    }
}

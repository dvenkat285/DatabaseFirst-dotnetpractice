using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtDtrDetail
    {
        public EtDtrDetail()
        {
            EtDeviceDetails = new HashSet<EtDeviceDetail>();
        }

        public int EtDtrId { get; set; }
        public int DtrId { get; set; }
        public string TransformerSno { get; set; } = null!;
        public int Capacity { get; set; }
        public string? Ratio { get; set; }
        public string? TransformerType { get; set; }
        public string? MountType { get; set; }
        public string? UtilityRefno { get; set; }
        public string? StructureCode { get; set; }
        public string? Location { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public int FeederId { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual EtFeederDetail Feeder { get; set; } = null!;
        public virtual ICollection<EtDeviceDetail> EtDeviceDetails { get; set; }
    }
}

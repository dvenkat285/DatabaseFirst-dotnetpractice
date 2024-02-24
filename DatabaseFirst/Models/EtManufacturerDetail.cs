using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtManufacturerDetail
    {
        public EtManufacturerDetail()
        {
            EtDcuDetails = new HashSet<EtDcuDetail>();
            EtMeterDetails = new HashSet<EtMeterDetail>();
        }

        public int MfId { get; set; }
        public string ManufacturerName { get; set; } = null!;
        public string? MfAddress { get; set; }
        public string? Phone { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual ICollection<EtDcuDetail> EtDcuDetails { get; set; }
        public virtual ICollection<EtMeterDetail> EtMeterDetails { get; set; }
    }
}

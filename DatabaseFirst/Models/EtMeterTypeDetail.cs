using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtMeterTypeDetail
    {
        public EtMeterTypeDetail()
        {
            EtMeterDetails = new HashSet<EtMeterDetail>();
        }

        public int MeterTypeId { get; set; }
        public string? MeterType { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual ICollection<EtMeterDetail> EtMeterDetails { get; set; }
    }
}

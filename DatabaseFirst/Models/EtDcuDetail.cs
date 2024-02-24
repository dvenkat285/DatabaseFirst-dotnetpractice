using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtDcuDetail
    {
        public int DcuId { get; set; }
        public string DcuSno { get; set; } = null!;
        public int? FeederId { get; set; }
        public string? DcuProdVersion { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public int? ManufacturerId { get; set; }
        public DateTimeOffset? ManufacturedDate { get; set; }
        public string? DcuHwVersion { get; set; }
        public string? DcuFwVersion { get; set; }
        public int? PanId { get; set; }
        public int? RfId { get; set; }
        public int? SimId { get; set; }
        public int? DeviceId { get; set; }
        public bool? IsActive { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual EtManufacturerDetail? Manufacturer { get; set; }
        public virtual EtSimDetail? Sim { get; set; }
    }
}

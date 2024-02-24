using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtServiceDetail
    {
        public int ServiceId { get; set; }
        public string? UniqueserviceNo { get; set; }
        public string? ServiceNo { get; set; }
        public int? FeederId { get; set; }
        public int? CategoryId { get; set; }
        public string? Phasetype { get; set; }
        public int? ConsumerId { get; set; }
        public string? Address { get; set; }
        public int? MeterId { get; set; }
        public int? DtrId { get; set; }
        public string? PoleId { get; set; }
        public decimal? ContractedLoad { get; set; }
        public string? OldMeterNo { get; set; }
        public decimal? OdMeterReading { get; set; }
        public int? StatusCode { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public bool? IsActive { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual EtMeterDetail? Meter { get; set; }
    }
}

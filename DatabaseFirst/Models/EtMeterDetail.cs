using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtMeterDetail
    {
        public EtMeterDetail()
        {
            EtServiceDetails = new HashSet<EtServiceDetail>();
        }

        public int MeterId { get; set; }
        public string? SerialNumber { get; set; }
        public int? MeterTypeId { get; set; }
        public string? Description { get; set; }
        public string? InterfaceType { get; set; }
        public string? ProductionVersion { get; set; }
        public int? DeviceTid { get; set; }
        public string? MeterAccuracyClass { get; set; }
        public string? MeterCurrentRating { get; set; }
        public string? MeterCategory { get; set; }
        public int? MultiplicationFactor { get; set; }
        public string? MeterHardwareVersion { get; set; }
        public string? MeterFirmwareVersion { get; set; }
        public string? Impulse { get; set; }
        public decimal? ModemAddress { get; set; }
        public string? ModemDescription { get; set; }
        public string? Protocol { get; set; }
        public int? PoleId { get; set; }
        public int? DtrId { get; set; }
        public int? MfId { get; set; }
        public string? CommType { get; set; }
        public int? DcuId { get; set; }
        public int? SimId { get; set; }
        public string? PhysicalAddress { get; set; }
        public DateTimeOffset? MfgDate { get; set; }
        public DateTimeOffset? WarrentyEnd { get; set; }
        public string? MeterValidFor { get; set; }
        public string? Location { get; set; }
        public string? LandMark { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public DateTimeOffset? InstallationDate { get; set; }
        public DateTimeOffset? CommisioningDate { get; set; }
        public DateTimeOffset? DeCommissioningDate { get; set; }
        public string? MeterStatus { get; set; }
        public string? FlagId { get; set; }
        public string? ClientSystemTitle { get; set; }
        public string? DedicatedKey { get; set; }
        public string? SystemTitle { get; set; }
        public string? OldSystemTitle { get; set; }
        public string? AuthenticationKey { get; set; }
        public string? EncryptionKey { get; set; }
        public string? MeterPicture { get; set; }
        public string? PaymentMode { get; set; }
        public bool? IsActive { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual EtMeterTypeDetail? MeterType { get; set; }
        public virtual EtManufacturerDetail? Mf { get; set; }
        public virtual EtSimDetail? Sim { get; set; }
        public virtual ICollection<EtServiceDetail> EtServiceDetails { get; set; }
    }
}

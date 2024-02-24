using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtDeviceDetail
    {
        public EtDeviceDetail()
        {
            TtDeviceNwInteruptions = new HashSet<TtDeviceNwInteruption>();
        }

        public int DeviceTid { get; set; }
        public int DeviceId { get; set; }
        public string? DeviceType { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceSerialNo { get; set; }
        public string? DeviceIp { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public int? DtrId { get; set; }
        public int? ConnectionStatus { get; set; }
        public bool? IsActive { get; set; }
        public string? Location { get; set; }
        public string? Landmark { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual EtDtrDetail? Dtr { get; set; }
        public virtual ICollection<TtDeviceNwInteruption> TtDeviceNwInteruptions { get; set; }
    }
}

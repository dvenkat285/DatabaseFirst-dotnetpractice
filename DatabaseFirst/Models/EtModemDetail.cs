using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtModemDetail
    {
        public int ModemId { get; set; }
        public int? DeviceId { get; set; }
        public string? ModemAddress { get; set; }
        public bool? IsActive { get; set; }
        public int Status { get; set; }
        public DateTimeOffset Sts { get; set; }
    }
}

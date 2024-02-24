using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Hierarcy
    {
        public string? SerialNumber { get; set; }
        public string ManufacturerName { get; set; } = null!;
        public DateTimeOffset? MfgDate { get; set; }
        public DateTimeOffset? InstallationDate { get; set; }
        public DateTimeOffset? CommisioningDate { get; set; }
        public string SimGsmno { get; set; } = null!;
        public string? SimIp { get; set; }
    }
}

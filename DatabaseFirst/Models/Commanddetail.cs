using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Commanddetail
    {
        public double? CommandId { get; set; }
        public string? CommandName { get; set; }
        public string? LogicalName { get; set; }
        public string? Obiscode { get; set; }
        public string? Obiscodehex { get; set; }
        public string? CommandType { get; set; }
        public string? CommandIsActive { get; set; }
        public double? DeviceId { get; set; }
        public DateTime? CrTs { get; set; }
    }
}

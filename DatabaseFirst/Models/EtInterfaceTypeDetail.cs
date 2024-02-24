using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtInterfaceTypeDetail
    {
        public int InterfaceTypeId { get; set; }
        public string? InterfaceType { get; set; }
        public DateTimeOffset Sts { get; set; }
    }
}

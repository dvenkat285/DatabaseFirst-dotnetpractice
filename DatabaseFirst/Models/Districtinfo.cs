using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Districtinfo
    {
        public int Districtid { get; set; }
        public string? Districtname { get; set; }
        public int? Stateid { get; set; }

        public virtual Statesinfo? State { get; set; }
    }
}

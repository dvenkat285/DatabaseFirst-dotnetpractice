using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Districctinfoo
    {
        public int Dctid { get; set; }
        public string? Dctname { get; set; }
        public int? Stateid { get; set; }

        public virtual Statesinfoo? State { get; set; }
    }
}

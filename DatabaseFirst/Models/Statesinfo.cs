using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Statesinfo
    {
        public Statesinfo()
        {
            Districtinfos = new HashSet<Districtinfo>();
        }

        public int Stateid { get; set; }
        public string? Statename { get; set; }
        public string? Statecode { get; set; }

        public virtual ICollection<Districtinfo> Districtinfos { get; set; }
    }
}

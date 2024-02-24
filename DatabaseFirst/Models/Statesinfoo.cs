using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Statesinfoo
    {
        public Statesinfoo()
        {
            Districctinfoo1s = new HashSet<Districctinfoo1>();
            Districctinfoos = new HashSet<Districctinfoo>();
        }

        public int Stateid { get; set; }
        public string? Statenmae { get; set; }
        public string? Statecode { get; set; }

        public virtual ICollection<Districctinfoo1> Districctinfoo1s { get; set; }
        public virtual ICollection<Districctinfoo> Districctinfoos { get; set; }
    }
}

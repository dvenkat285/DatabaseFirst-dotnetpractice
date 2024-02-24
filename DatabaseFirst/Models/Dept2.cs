using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Dept2
    {
        public Dept2()
        {
            Emp11s = new HashSet<Emp11>();
        }

        public int Deptno { get; set; }
        public string? Dname { get; set; }
        public string? Loc { get; set; }

        public virtual ICollection<Emp11> Emp11s { get; set; }
    }
}

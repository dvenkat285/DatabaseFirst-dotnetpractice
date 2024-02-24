using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Level
    {
        public Level()
        {
            InverseCircle = new HashSet<Level>();
        }

        public int Regionid { get; set; }
        public string Name { get; set; } = null!;
        public int? Circleid { get; set; }

        public virtual Level? Circle { get; set; }
        public virtual ICollection<Level> InverseCircle { get; set; }
    }
}

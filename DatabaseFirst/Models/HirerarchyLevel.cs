using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class HirerarchyLevel
    {
        public HirerarchyLevel()
        {
            InverseLevel = new HashSet<HirerarchyLevel>();
        }

        public int HirerarchyLevelId { get; set; }
        public string? LevelType { get; set; }
        public string? LevelName { get; set; }
        public int? LevelId { get; set; }
        public DateTimeOffset Sts { get; set; }

        public virtual HirerarchyLevel? Level { get; set; }
        public virtual ICollection<HirerarchyLevel> InverseLevel { get; set; }
    }
}

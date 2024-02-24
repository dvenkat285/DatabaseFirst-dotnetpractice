using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Sowmyatable
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string Role { get; set; } = null!;
        public TimeSpan Time { get; set; }
        public decimal? HtDataParamTmultctid { get; set; }
        public DateTime? Rtc { get; set; }

        public virtual SowmyaHtParamTmu? HtDataParamTmultct { get; set; }
    }
}

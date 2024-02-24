using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Regexdetail
    {
        public double? RegexId { get; set; }
        public string? Regex { get; set; }
        public string? RegexDescription { get; set; }
        public double? CommandId { get; set; }
        public DateTime? CrTs { get; set; }
    }
}

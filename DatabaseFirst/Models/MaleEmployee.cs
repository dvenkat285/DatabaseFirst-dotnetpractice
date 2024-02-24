using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class MaleEmployee
    {
        public int EId { get; set; }
        public string? EName { get; set; }
        public int? ESalary { get; set; }
        public int? EAge { get; set; }
        public string? EGender { get; set; }
        public string? EDept { get; set; }
    }
}

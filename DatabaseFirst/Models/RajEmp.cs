using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class RajEmp
    {
        public byte? Empid { get; set; }
        public string? Ename { get; set; }
        public string? Job { get; set; }
        public decimal? Sal { get; set; }
        public DateTime? Hiredate { get; set; }
        public byte? Age { get; set; }
        public string? Gender { get; set; }
    }
}

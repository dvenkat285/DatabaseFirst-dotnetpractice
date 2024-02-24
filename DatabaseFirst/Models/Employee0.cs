using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Employee0
    {
        public string? Empno { get; set; }
        public string? Empname { get; set; }
        public int? Empsalary { get; set; }
        public string? Empcity { get; set; }
        public byte[] JoiningDate { get; set; } = null!;
    }
}

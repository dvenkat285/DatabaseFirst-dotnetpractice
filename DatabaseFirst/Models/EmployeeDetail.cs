using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EmployeeDetail
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; } = null!;
        public string EmpCity { get; set; } = null!;
        public int EmpSalary { get; set; }
        public string? MySal { get; set; }
        public string? Gender { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EmployeeDetails3
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; } = null!;
        public int EmpSalary { get; set; }
        public string EmpCity { get; set; } = null!;
    }
}

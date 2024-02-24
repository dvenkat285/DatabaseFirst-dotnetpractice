using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EmployeeView3
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; } = null!;
        public string EmpCity { get; set; } = null!;
        public int EmpSalary { get; set; }
    }
}

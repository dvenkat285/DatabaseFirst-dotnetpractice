using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EmployeeView4
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; } = null!;
        public int EmpSalary { get; set; }
        public string? MobileNo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class DetailsEmp
    {
        public int Empno { get; set; }
        public string? Ename { get; set; }
        public string? Job { get; set; }
        public DateTime? Sal { get; set; }
    }
}

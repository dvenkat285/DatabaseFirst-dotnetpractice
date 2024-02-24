using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Customers22
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string? Address { get; set; }
        public decimal? Salary { get; set; }
    }
}

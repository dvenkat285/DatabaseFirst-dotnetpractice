using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Orders2
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? DepartmentName { get; set; }
    }
}

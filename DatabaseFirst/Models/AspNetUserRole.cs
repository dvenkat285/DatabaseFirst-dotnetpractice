using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class AspNetUserRole
    {
        public int UserId { get; set; }
        public string RoleId { get; set; } = null!;
    }
}

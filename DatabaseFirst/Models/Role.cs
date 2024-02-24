using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string? RoleDescription { get; set; }
        public bool? IsSysAdmin { get; set; }
        public DateTime LastModified { get; set; }
    }
}

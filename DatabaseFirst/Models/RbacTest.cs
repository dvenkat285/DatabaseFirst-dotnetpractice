using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class RbacTest
    {
        public int UserId { get; set; }
        public string RoleName { get; set; } = null!;
        public string RolePermission { get; set; } = null!;
    }
}

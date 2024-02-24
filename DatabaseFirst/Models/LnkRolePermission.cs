using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class LnkRolePermission
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
    }
}

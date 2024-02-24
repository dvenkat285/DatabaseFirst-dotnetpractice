using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtRolePrivRelDetail
    {
        public int RolePrivilegeRelId { get; set; }
        public int RoleId { get; set; }
        public int PrivilegeId { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual EtPrivilegeDetail Privilege { get; set; } = null!;
        public virtual EtRoleDetail Role { get; set; } = null!;
    }
}

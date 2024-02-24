using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtUserRoleRelDetail
    {
        public int UserRoleRelId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual EtRoleDetail Role { get; set; } = null!;
        public virtual EtUserDetail User { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtRoleDetail
    {
        public EtRoleDetail()
        {
            EtRolePrivRelDetails = new HashSet<EtRolePrivRelDetail>();
            EtUserRoleRelDetails = new HashSet<EtUserRoleRelDetail>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; } = null!;
        public DateTimeOffset Crts { get; set; }

        public virtual ICollection<EtRolePrivRelDetail> EtRolePrivRelDetails { get; set; }
        public virtual ICollection<EtUserRoleRelDetail> EtUserRoleRelDetails { get; set; }
    }
}

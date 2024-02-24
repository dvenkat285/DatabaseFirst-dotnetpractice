using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtPrivilegeDetail
    {
        public EtPrivilegeDetail()
        {
            EtRolePrivRelDetails = new HashSet<EtRolePrivRelDetail>();
        }

        public int PrivilegeId { get; set; }
        public string Privilege { get; set; } = null!;
        public DateTimeOffset Crts { get; set; }

        public virtual ICollection<EtRolePrivRelDetail> EtRolePrivRelDetails { get; set; }
    }
}

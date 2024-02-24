using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtUserDetail
    {
        public EtUserDetail()
        {
            EtUserRoleRelDetails = new HashSet<EtUserRoleRelDetail>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Salt { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? MobileNo { get; set; }
        public string? Designation { get; set; }
        public DateTimeOffset? LastPasswordChangedTime { get; set; }
        public DateTimeOffset? LastLoginTimeUhes { get; set; }
        public DateTimeOffset? LastLoginTimeMdms { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset Crts { get; set; }

        public virtual ICollection<EtUserRoleRelDetail> EtUserRoleRelDetails { get; set; }
    }
}

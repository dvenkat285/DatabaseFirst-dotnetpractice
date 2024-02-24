using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class LnkUserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}

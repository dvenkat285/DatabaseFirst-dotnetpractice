using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class AlekyaActiveDirectory
    {
        public int ActiveDirectoryId { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Role { get; set; }
        public string? Designation { get; set; }
        public string? Email { get; set; }
        public string? GroupName { get; set; }
        public string? Members { get; set; }
    }
}

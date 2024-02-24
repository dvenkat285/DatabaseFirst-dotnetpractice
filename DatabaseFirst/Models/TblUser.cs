using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? Dob { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
        public string? Contactno { get; set; }
        public string? Gender { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Workers1
    {
        public int Workerid { get; set; }
        public string Firstname { get; set; } = null!;
        public string? Lastname { get; set; }
        public string? Emailid { get; set; }
        public string? Phonenumber { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Worker1
    {
        public int Workerid { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Emailid { get; set; }
        public string? Phonenumber { get; set; }
        public string? Department { get; set; }
    }
}

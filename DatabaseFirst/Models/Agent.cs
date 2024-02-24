using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Agent
    {
        public string? AgentCode { get; set; }
        public string? AgentName { get; set; }
        public string? WorkingArea { get; set; }
        public int? Comm { get; set; }
        public long? PhoneNo { get; set; }
    }
}

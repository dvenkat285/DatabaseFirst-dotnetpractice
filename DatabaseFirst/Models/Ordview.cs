using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Ordview
    {
        public int? OrdNum { get; set; }
        public int? OrdAmount { get; set; }
        public string? AgentCode { get; set; }
        public string? AgentName { get; set; }
        public string? CustName { get; set; }
    }
}

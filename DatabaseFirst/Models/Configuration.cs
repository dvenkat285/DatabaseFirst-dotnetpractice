using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Configuration
    {
        public double? ConfigurationId { get; set; }
        public double? AssociationId { get; set; }
        public double? InterfaceClassId { get; set; }
        public double? AttributeId { get; set; }
        public string? MethodId { get; set; }
        public string? DataTypeId { get; set; }
        public double? CommandId { get; set; }
        public double? ParameterId { get; set; }
        public double? Priority { get; set; }
        public DateTime? CrTs { get; set; }
    }
}

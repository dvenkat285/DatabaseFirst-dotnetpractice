using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Parameterdetail
    {
        public double? ParameterId { get; set; }
        public string? ParameterName { get; set; }
        public string? ParameterDescription { get; set; }
        public double? ParameterLength { get; set; }
        public string? ParameterUnits { get; set; }
        public double? ParameterScalar { get; set; }
        public string? OperationType { get; set; }
        public string? IsReverse { get; set; }
        public string? ParameterIsActive { get; set; }
        public DateTime? CrTs { get; set; }
    }
}

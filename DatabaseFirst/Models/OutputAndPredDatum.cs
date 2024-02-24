using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class OutputAndPredDatum
    {
        public DateTime Timestamp { get; set; }
        public double Actual { get; set; }
        public double PredictedTarget { get; set; }
    }
}

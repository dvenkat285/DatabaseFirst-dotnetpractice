using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class InputDataFile
    {
        public string? Index { get; set; }
        public string? Timestamp { get; set; }
        public string? Energy { get; set; }
        public string? Visibility { get; set; }
        public string? WindBearing { get; set; }
        public string? Temperature { get; set; }
        public string? DewPoint { get; set; }
        public string? Pressure { get; set; }
        public string? ApparentTemperature { get; set; }
        public string? WindSpeed { get; set; }
        public string? Humidity { get; set; }
        public string? Energy3TsMa { get; set; }
        public string? Energy5TsMa { get; set; }
        public string? Energy7TsMa { get; set; }
        public string? Energy1DMa { get; set; }
        public string? Energy1DSa { get; set; }
    }
}

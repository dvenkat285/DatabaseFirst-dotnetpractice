using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public string? CityDescription { get; set; }
        public string? Capital { get; set; }
    }
}

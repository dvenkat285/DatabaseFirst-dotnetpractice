using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Car
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? Model { get; set; }
        public long? Price { get; set; }
        public string? Location { get; set; }
    }
}

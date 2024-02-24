using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class ProductsV
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
    }
}

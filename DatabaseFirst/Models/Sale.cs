using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public string ManufacturerName { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Colour { get; set; } = null!;
        public decimal EngineSize { get; set; }
        public int EnginePower { get; set; }
        public string FuelType { get; set; } = null!;
        public bool Lhd { get; set; }
    }
}

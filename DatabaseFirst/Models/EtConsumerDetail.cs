using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtConsumerDetail
    {
        public int ConsumerId { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? ConsumerRelationNo { get; set; }
        public decimal? AadharNo { get; set; }
        public string? FatherHusbandName { get; set; }
        public bool? GovtEmployee { get; set; }
        public string? Address { get; set; }
        public string? CityVillage { get; set; }
        public string? Mandal { get; set; }
        public int? Pincode { get; set; }
        public string? PhoneNo { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public DateTimeOffset Crts { get; set; }
    }
}

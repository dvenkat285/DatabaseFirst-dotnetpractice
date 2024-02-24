using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class EtNopDetail
    {
        public EtNopDetail()
        {
            EtSimDetails = new HashSet<EtSimDetail>();
        }

        public int NopId { get; set; }
        public string? NopName { get; set; }
        public string? Apn { get; set; }
        public string? ApnNo { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset CrTs { get; set; }

        public virtual ICollection<EtSimDetail> EtSimDetails { get; set; }
    }
}

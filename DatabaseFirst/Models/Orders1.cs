using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Orders1
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int? PersonId { get; set; }

        public virtual Person? Person { get; set; }
    }
}

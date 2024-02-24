using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Person
    {
        public Person()
        {
            Orders1s = new HashSet<Orders1>();
        }

        public int PersonId { get; set; }
        public string LastName { get; set; } = null!;
        public string? FirstName { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<Orders1> Orders1s { get; set; }
    }
}

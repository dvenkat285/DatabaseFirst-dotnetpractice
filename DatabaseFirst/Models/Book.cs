﻿using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApp06febAssess.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public string? Author { get; set; }
    }
}

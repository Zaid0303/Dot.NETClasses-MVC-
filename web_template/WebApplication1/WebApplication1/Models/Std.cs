using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Std
    {
        public int Id { get; set; }
        public string StdName { get; set; } = null!;
        public int StdAge { get; set; }
    }
}

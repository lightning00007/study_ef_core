using System;
using System.Collections.Generic;
using System.Text;

namespace SShop.Domain
{
    public class Specification
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string LocalName { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}

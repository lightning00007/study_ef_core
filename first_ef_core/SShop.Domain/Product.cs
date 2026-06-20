using System;
using System.Collections.Generic;
using System.Text;

namespace SShop.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int OriginalPrice { get; set; } = 0;
        public int ReducedPrice { get; set; } = 0;

        public List<Specification> Specs { get; set; } = new List<Specification>();
    }
}

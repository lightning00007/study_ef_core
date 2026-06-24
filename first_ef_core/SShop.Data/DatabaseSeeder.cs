using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SShop.Data
{
    public class DatabaseSeeder
    {
        public static void Seed(AppDbContext context)
        {
            // Check if the database is empty
            if (!context.Products.Any())
            {
                // Add initial data to the database
                var products = new List<Domain.Product>
                {
                    new Domain.Product { Name = "Product 1", OriginalPrice = 1000, ReducedPrice = 800, Specs = new List<Domain.Specification>(){new Domain.Specification { Type = "Spec Type 1", Name = "Green",LocalName = "Xanh"} } },
                    new Domain.Product { Name = "Product 2", OriginalPrice = 1500, ReducedPrice = 1200, Specs = new List<Domain.Specification>(){new Domain.Specification { Type = "Spec Type 2", Name = "Blue",LocalName = "Xanh"} } },
                    new Domain.Product { Name = "Product 3", OriginalPrice = 700, ReducedPrice = 560, Specs = new List<Domain.Specification>(){new Domain.Specification { Type = "Spec Type 3", Name = "Red",LocalName = "Do"} } }
                };
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}

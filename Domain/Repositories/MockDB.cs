using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repositories
{
    public class MockDB : IRepository
    {

        //---------------------------------
        //Initialise some mock data
        private List<Product> listings =
            new List<Product>()
            {
                    new Product { ProductId = 1, ProductName = "Prod1", Price = 464.90, Rating = 1, category = Categories.allowedCategoies.Football },
                    new Product { ProductId = 2, ProductName = "Prod2", Price = 464.90, Rating = 2, category = Categories.allowedCategoies.Hurling},
                    new Product { ProductId = 3, ProductName = "Prod3", Price = 464.90, Rating = 3, category = Categories.allowedCategoies.Clothes },
            };
        //---------------------------------
        public IEnumerable<Product> GetProduct(Categories.allowedCategoies cat, int rating)
        {
            var listing = listings.FindAll(l => l.category == cat);
            listing = listing.FindAll(l => l.Rating == rating);
            return listing;
        }

        public IEnumerable<Product> GetProduct()
        {
            return listings.OrderBy(s => s.ProductId);
        }
    }
}

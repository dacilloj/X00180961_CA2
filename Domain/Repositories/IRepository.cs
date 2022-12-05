using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IRepository
    {
        public IEnumerable<Product> GetAll();
        public IEnumerable<Product> GetProductsByPrice(double pricemin, double pricemax);
        public IEnumerable<Product> GetProductsByCategory(Categories.allowedCategoies cat, int rating);
    }
}

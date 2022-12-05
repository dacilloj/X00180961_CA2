﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IRepository
    {
        public 
        IEnumerable<Product> GetProducts();
        Product GetProduct(int productid);
    }
}

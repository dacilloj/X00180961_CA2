using Domain;
using Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace X00180961_CA2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository _db;

        public ProductController(IRepository db)
        {
            _db = db; // new MockDB();
        }

        
        [HttpGet]
        [Route("Product/{cat}/{rating}")]
        public IEnumerable<Product> GetAllListings(Categories.allowedCategoies cat, int rating)
        {
            var listing = _db.GetProductsByCategory(cat, rating).ToList();
               
            return listing;            
        }
        [Route("Product/{minprice}/{maxprice}")]
        [HttpGet]
        public IEnumerable<Product> GetAllListings(int minprice, int maxprice)
        {
            var listing = _db.GetProductsByPrice(minprice, maxprice).ToList();
            
            return listing;
        }



    }
}

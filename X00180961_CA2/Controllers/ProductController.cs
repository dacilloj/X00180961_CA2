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

        // GET https://localhost:7117/api/Stock   (api/stock is the URL that will get us to this controller .. 
        [HttpGet("{category}")]
        public IEnumerable<Product> GetAllListings(Categories.allowedCategoies cat, int rating)
        {
            var listing = _db.GetProductsByCategory(cat, rating).ToList();
            //return Ok(_db.GetStocks().ToList());      // 200 OK, listings serialized in response body
            return listing;            
        }

        [HttpGet("{minprice}{maxprice")]
        public IEnumerable<Product> GetAllListings(int minprice, int maxprice)
        {
            var listing = _db.GetProductsByCategory(minprice, maxprice).ToList();
            //return Ok(_db.GetStocks().ToList());      // 200 OK, listings serialized in response body
            return listing;
        }



    }
}

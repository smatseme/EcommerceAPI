using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_commerce.Controllers
{
    public class BucketController : ApiController
    {
        List<Product> BucketItems = new List<Product>();
        public IHttpActionResult AddProductToBucket()
        {
            Product p = new Product();
            BucketItems = new List<Product>() {
                new Product()
                {
                    Product_Name = p.Product_Name,
                    Price = p.Price
                }
            };
            return Ok();
        }

        public decimal GetBucketValue()
        {
            decimal total = Convert.ToDecimal(BucketItems.Select(x => x.Price).Sum());
            return total;
        }
    }
}

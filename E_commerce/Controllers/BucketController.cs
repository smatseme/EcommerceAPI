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
        List<Bundles> BucketItems = new List<Bundles>();
        public IHttpActionResult AddProductToBucket()
        {
            Bundles p = new Bundles();
            BucketItems = new List<Bundles>() {
                new Bundles()
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_commerce.Controllers
{
    public class ProductController : ApiController
    {
        E_CommerceEntities e_CommerceEntities = new E_CommerceEntities();
        

        public IEnumerable<Product> GetAllProducts()
        {
            return e_CommerceEntities.Products.ToList().AsEnumerable();
        }

        public IHttpActionResult GetProductByCatID(int id)
        {
            var prod = (from a in e_CommerceEntities.Products
                        where a.Id == id
                        select a).FirstOrDefault();
         
            return Ok(prod);
        }

       
    }
}

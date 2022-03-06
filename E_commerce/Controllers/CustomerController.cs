using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_commerce.Controllers
{
    public class CustomerController : ApiController
    {
        E_CommerceEntities e_CommerceEntities = new E_CommerceEntities();

        public IHttpActionResult GetCustomerByID(int id)
        {
            var cust = (from a in e_CommerceEntities.Customers
                        where a.Id == id
                        select a).FirstOrDefault();

           // $"Couldn’t found Book of id {id}"
            return Ok(cust);
        }

       
    }
}

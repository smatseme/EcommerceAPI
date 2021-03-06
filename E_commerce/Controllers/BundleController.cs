using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_commerce.Controllers
{
    public class BundleController : ApiController
    {
        E_CommerceEntities e_CommerceEntities = new E_CommerceEntities();
        
        public IEnumerable<bundle> GetAllProducts()
        {
            return e_CommerceEntities.bundles.ToList().AsEnumerable();
        }

    }
}

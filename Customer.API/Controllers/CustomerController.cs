using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{
    
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
        public CustomerController()
        {

        }
        [HttpGet]
        public List<string> Get() {
            var productList = new List<string> { "Customer 1", "Customer 2", "Customer 3" };
            return productList;
        }
    }
}

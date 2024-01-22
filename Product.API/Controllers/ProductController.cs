using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Route("api/product")]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {

        }
        [HttpGet]
      //  [Route("GetProductList")]
        public List<string> Get()
        {
            var productList = new List<string> { "Product 1", "Product 2", "Product 3" };
                return productList;
        }
        [HttpGet("productId/{productId}")]
        //[Route("ProductVersion")]
        public string ProductVersion([FromRoute(Name = "productId")] int id)
        {
            return $"product with id {id} is removed";
        }
    }
    public class RetrieveDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Type { get; set; }
    }
}

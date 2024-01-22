using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.API.Services;
//using ProductAPI.Services;
using Product.API.Models;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }
        [HttpGet]
        //  [Route("GetProductList")]
        //public List<string> Get()
        //{
        //    var productList = new List<string> { "Product 1", "Product 2", "Product 3" };
        //        return productList;
        //}
        public IEnumerable<Products> Get()
        {
            var productList = productService.GetProductList();
            return productList;

        }
        [HttpGet("productId/{productId}")]
        //[Route("ProductVersion")]
        public string ProductVersion([FromRoute(Name = "productId")] int id)
        {
            return $"product with id {id} is removed";
        }
        [HttpPost]
        public Products AddProduct(Products product)
        {
            return productService.AddProduct(product);
        }
    }
    public class RetrieveDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Type { get; set; }
    }
}

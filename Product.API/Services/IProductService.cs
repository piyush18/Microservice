using System.Collections.Generic;
using Product.API.Models;

namespace Product.API.Services
{
    public interface IProductService
    {
        public IEnumerable<Products> GetProductList();
        public Products GetProductById(int id);
        public Products AddProduct(Products product);
        public Products UpdateProduct(Products product);
        public bool DeleteProduct(int Id);
    }
}

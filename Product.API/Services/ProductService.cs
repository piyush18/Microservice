using System.Collections.Generic;
using System.Linq;
using Product.API.Data;
using Product.API.Models;

namespace Product.API.Services
{
    public class ProductService : IProductService
    {
        private readonly DbContextClass _dbContext;

        public ProductService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Products> GetProductList()
        {
            return _dbContext.Productss.ToList();
        }
        public Products GetProductById(int id)
        {
            return _dbContext.Productss.Where(x => x.ProductId == id).FirstOrDefault();
        }

        public Products AddProduct(Products product)
        {
            var result = _dbContext.Productss.Add(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public Products UpdateProduct(Products product)
        {
            var result = _dbContext.Productss.Update(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }
        public bool DeleteProduct(int Id)
        {
            var filteredData = _dbContext.Productss.Where(x => x.ProductId == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }
    }
}

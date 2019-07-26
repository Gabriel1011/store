using System.Collections.Generic;
using Store.Data;
using Store.Models;

namespace Store.Repositories
{
    public class ProductRepository
    {
        private readonly StoreDataContext _context;

        public ProductRepository(StoreDataContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Get()
        {
            return _context.Products;
        }

        public void Post(Product Product)
        {
             _context.Products.Add(Product);
             _context.SaveChanges();
        }
    }
}
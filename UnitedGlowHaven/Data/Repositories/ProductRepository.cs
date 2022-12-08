using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UnitedGlowHaven.Models;

namespace UnitedGlowHaven.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly UnitedGlowHavenContext _context;
        private readonly DbSet<Product> _producten;

        public ProductRepository(UnitedGlowHavenContext context)
        {
            _context = context;
            _producten = context.Producten;
        }
        public Product Add(Product product)
        {
            return _producten.Add(product).Entity;
        }
        public IEnumerable<Product> All()
        {
            return _context.Producten.ToList();
        }

        public Product Find(int productId)
        {
            return _context.Producten.Find(productId);
        }

        public IQueryable<Product> Search()
        {
            return _context.Producten.AsQueryable();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnitedGlowHaven.Models;

namespace UnitedGlowHaven.Data.Repositories
{
    public interface IProductRepository
    {
        Product Add(Product product);
        Product Find(int productId);
        IEnumerable<Product> All();
        IQueryable<Product> Search();
    }
}

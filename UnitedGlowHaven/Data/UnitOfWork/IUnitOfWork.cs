using System.Threading.Tasks;
using UnitedGlowHaven.Data.Repositories;
using UnitedGlowHaven.Models;

namespace UnitedGlowHaven.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<Product> ProductRepository { get; }
        IGenericRepository<Categorie> CategorieRepository { get; }
        IGenericRepository<Winkelmand> WinkelmandRepository { get; }
        IGenericRepository<WinkelmandProduct> WinkelmandProductRepository { get; }
        Task Save();
    }
}

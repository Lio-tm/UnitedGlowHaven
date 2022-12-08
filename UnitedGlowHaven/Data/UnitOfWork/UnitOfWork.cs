using System.Threading.Tasks;
using UnitedGlowHaven.Data.Repositories;
using UnitedGlowHaven.Models;

namespace UnitedGlowHaven.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UnitedGlowHavenContext _context;
        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<Categorie> _categorieRepository;
        public UnitOfWork(UnitedGlowHavenContext context)
        {
            _context = context;
        }

        public IGenericRepository<Product> ProductRepository
        {
            get
            {
                if (this._productRepository == null)
                {
                    this._productRepository = new GenericRepository<Product>(_context);
                }
                return _productRepository;
            }
        }
        public IGenericRepository<Categorie> CategorieRepository
        {
            get
            {
                if (this._categorieRepository == null)
                {
                    this._categorieRepository = new GenericRepository<Categorie>(_context);
                }
                return _categorieRepository;
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}

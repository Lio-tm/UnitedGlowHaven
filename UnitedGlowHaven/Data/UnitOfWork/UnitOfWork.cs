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
        private IGenericRepository<Winkelmand> _winkelmandRepository;
        private IGenericRepository<WinkelmandProduct> _winkelmandProductRepository;
        private IGenericRepository<ProductMaat> _productMaatRepository;
        public UnitOfWork(UnitedGlowHavenContext context)
        {
            _context = context;
        }
        public IGenericRepository<WinkelmandProduct> WinkelmandProductRepository
        {
            get
            {
                if (this._winkelmandProductRepository == null)
                {
                    this._winkelmandProductRepository = new GenericRepository<WinkelmandProduct>(_context);
                }
                return _winkelmandProductRepository;
            }
        }
        public IGenericRepository<Winkelmand> WinkelmandRepository
        {
            get
            {
                if (this._winkelmandRepository == null)
                {
                    this._winkelmandRepository = new GenericRepository<Winkelmand>(_context);
                }
                return _winkelmandRepository;
            }
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
        public IGenericRepository<ProductMaat> ProductMaatRepository
        {
            get
            {
                if (this._productMaatRepository == null)
                {
                    this._productMaatRepository = new GenericRepository<ProductMaat>(_context);
                }
                return _productMaatRepository;
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}

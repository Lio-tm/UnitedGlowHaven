using System.Linq;
using System.Threading.Tasks;

namespace UnitedGlowHaven.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly UnitedGlowHavenContext _context;
        public GenericRepository(UnitedGlowHavenContext context)
        {
            _context = context;
        }
        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }
        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}

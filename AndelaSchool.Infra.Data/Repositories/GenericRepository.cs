using AndelaSchool.Domain.Core.Interfaces;
using AndelaSchool.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AndelaSchool.Infra.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AndelaSchoolContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(AndelaSchoolContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();
    }
}
using CallManager.Application.Interfaces;
using CallManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CallManager.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly CallManagerDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(CallManagerDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> ObterTodosAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T?> ObterPorIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task AdicionarAsync(T entidade)
        {
            await _dbSet.AddAsync(entidade);
            await _context.SaveChangesAsync();
        }

        public virtual async Task AtualizarAsync(T entidade)
        {
            _dbSet.Update(entidade);
            await _context.SaveChangesAsync();
        }

        public virtual async Task RemoverAsync(object id)
        {
            var entidade = await _dbSet.FindAsync(id);
            if (entidade != null)
            {
                _dbSet.Remove(entidade);
                await _context.SaveChangesAsync();
            }
        }

        public virtual async Task<bool> ExisteAsync(object id)
        {
            var entidade = await _dbSet.FindAsync(id);
            return entidade != null;
        }
    }
}

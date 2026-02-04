using ApiDistribuidora.DTOs.Filters;
using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Data;
using BackDistribuidora.Entidades.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiDistribuidora.Repositories.Implementacoes
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }
        public virtual async Task<T?> GetByIdAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }
        public Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
        public Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            return Task.CompletedTask;
        }
        protected IQueryable<TQuery> AplicarFiltroTemporal<TQuery>(IQueryable<TQuery> query,
            BaseFilterInput filtro) where TQuery : class, ITemporalEntity
        {
            if (filtro.DataInicio.HasValue)
            {
                query = query.Where(e => e.DataMovimentacao >= filtro.DataInicio.Value.Date);
            }
            if (filtro.DataFim.HasValue)
            {
                var datafimComMargem = filtro.DataFim.Value.Date.AddDays(1);

                query = query.Where(e => e.DataMovimentacao <= datafimComMargem);
            }
            return query;
        }
    }
}

using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Data;
using BackDistribuidora.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace ApiDistribuidora.Repositories.Implementacoes
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Categoria>> GetByNameAsync(string name)
        {
            return await _context.Categorias
                .Where(c => EF.Functions.Like(c.Nome, $"%{c.Nome}%") )
                .AsNoTracking()
                .ToListAsync();
        }
    }
}

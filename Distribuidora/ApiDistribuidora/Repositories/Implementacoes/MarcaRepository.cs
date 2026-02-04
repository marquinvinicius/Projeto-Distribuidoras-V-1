using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Data;
using BackDistribuidora.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApiDistribuidora.Repositories.Implementacoes
{
    public class MarcaRepository : Repository<Marca>, IMarcaRepository
    {
        public MarcaRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Marca>> GetByNameAsync(string nome)
        {
            return await _context.Marcas
                .Where(m => EF.Functions.Like(m.Nome, $"%{nome}%"))
                .AsNoTracking()
                .ToListAsync();
        }
    }
}

using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Data;
using BackDistribuidora.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiDistribuidora.Repositories.Implementacoes
{
    public class MarcaCategoriaRepository : Repository<MarcaCategoria>, IMarcaCategoriaRepository
    {
        public MarcaCategoriaRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<MarcaCategoria> GetAsync(int marcaId, int categoriaId)
        {
            return await _context.Set<MarcaCategoria>()
                .FirstOrDefaultAsync(mc => mc.MarcaId == marcaId &&
                mc.CategoriaId == categoriaId);
        }

        public async Task<IEnumerable<MarcaCategoria>> GetByMarcaAsync(int marcaId)
        {
            return await _context.Set<MarcaCategoria>().
                Include(mc => mc.Categoria)
                .Where(mc => mc.MarcaId == marcaId)
                .ToListAsync();
        }
    }
}

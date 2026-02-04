using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Data;
using BackDistribuidora.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiDistribuidora.Repositories.Implementacoes
{
    public class PrecoVendaRepository : Repository<PrecoVenda>, IPrecoVendaRepository
    {
        public PrecoVendaRepository(AppDbContext context) : base(context)
        {
        }

        public async Task AddRangeAsync(IEnumerable<PrecoVenda> precos)
        {
            await _context.Set<PrecoVenda>().AddRangeAsync(precos);
        }

        public async Task<IEnumerable<PrecoVenda>> GetHistoricoPrecosAsync(int produtoId)
        {
            return await _context.PrecosVenda
                .Where(p => p.ProdutoId == produtoId)
                .OrderBy(p => p.DataInicio)
                .ToListAsync();
        }

        public async Task<IEnumerable<PrecoVenda>> GetPrecosAtuaisAsync()
        {
            return await _context.PrecosVenda
                .Where(p => p.DataFim == null)
                .ToListAsync();
        }
        public async Task<PrecoVenda> GetPrecoAtualByProdutoIdAsync(int produtoId)
        {
            return await _context.PrecosVenda
                .Where(p => p.ProdutoId == produtoId)
                .OrderByDescending(p => p.DataInicio)
                .FirstOrDefaultAsync();
        }
    }
}

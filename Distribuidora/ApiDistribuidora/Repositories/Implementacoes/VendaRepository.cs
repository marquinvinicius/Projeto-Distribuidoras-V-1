using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Data;
using BackDistribuidora.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiDistribuidora.Repositories.Implementacoes
{
    public class VendaRepository : Repository<Venda>, IVendaRepository
    {
        public VendaRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Venda?> GetVendaComItensAsync(int id)
        {
            return await _context.Vendas
                .Include(v => v.Itens)
                .SingleOrDefaultAsync(v => v.Id == id);
        }
    }
}

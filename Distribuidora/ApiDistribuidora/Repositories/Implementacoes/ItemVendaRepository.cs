using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Data;
using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Repositories.Implementacoes
{
    public class ItemVendaRepository : Repository<ItemVenda>, IItemVendaRepository
    {
        public ItemVendaRepository(AppDbContext context) : base(context)
        {
        }
    }
}

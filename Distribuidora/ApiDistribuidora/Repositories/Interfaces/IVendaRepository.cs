using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Repositories.Interfaces
{
    public interface IVendaRepository : IRepository<Venda>
    {
        Task<Venda?> GetVendaComItensAsync(int id);
    }
}

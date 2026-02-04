using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Repositories.Interfaces
{
    public interface IPrecoVendaRepository : IRepository<PrecoVenda>
    {
        Task<IEnumerable<PrecoVenda>> GetHistoricoPrecosAsync(int produtoId);
        Task AddRangeAsync (IEnumerable<PrecoVenda> precos);
        Task<PrecoVenda> GetPrecoAtualByProdutoIdAsync(int produtoId);
        Task<IEnumerable<PrecoVenda>> GetPrecosAtuaisAsync();
    }
}

using ApiDistribuidora.DTOs.Filters;
using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Repositories.Interfaces
{
    public interface IMovimentacaoEstoqueRepository : IRepository<MovimentacaoEstoque>
    {
        Task AdicionarAsync(MovimentacaoEstoque movimentacao);
        Task AdicionarRangeAsync(IEnumerable<MovimentacaoEstoque> movimentoes);
        Task<IEnumerable<MovimentacaoEstoque>> ObterPorProdutoIdAsync(int produtoId);
        Task<IEnumerable<MovimentacaoEstoque>> ObterPorFiltroAsync(MovimentacaoFilterInput filtro);
    }
}

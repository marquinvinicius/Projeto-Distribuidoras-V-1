using ApiDistribuidora.DTOs.Filters;
using BackDistribuidora.Entidades;
using BackDistribuidora.Entidades.Enums;
using Distribuidora.Back.Entidades.Object_Values;

namespace ApiDistribuidora.Services.Interfaces
{
    public interface IMovimentacaoEstoqueService
    {
        Task ProcessarMovimentacao(int produtoId, EstoqueProdutoValue quantidade,
        CustoProdutoValue custo ,TipoTransacao tipoTransacao, TipoUnidade tipoUnidade);
        Task<IEnumerable<MovimentacaoEstoque>> ObterMovimentacoesPorProdutoAsync(int produtoId);
        Task<IEnumerable<MovimentacaoEstoque>> ObterTodasMovimentacoesAsync();
        Task<MovimentacaoEstoque?> ObterMovimentacaoPorIdAsync(int id);
        Task<IEnumerable<MovimentacaoEstoque>> ObterMovimentacoesPorFiltroAsync(MovimentacaoFilterInput filterInput);
    }
}

using ApiDistribuidora.Estrategy.Interface;
using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Entidades;
using BackDistribuidora.Entidades.Enums;
using Distribuidora.Back.Entidades.Object_Values;

namespace ApiDistribuidora.Estrategy.Implementacao
{
    public class SaidaPerdaTrocaEstrategy : IMovimentacaoEstrategy
    {
        private readonly IMovimentacaoEstoqueRepository _movEstoque;
        
        public SaidaPerdaTrocaEstrategy (IMovimentacaoEstoqueRepository movimentacaoEstoque)
        {
            _movEstoque = movimentacaoEstoque;
        }
        public TipoTransacao Tipo => TipoTransacao.SaidaPerdaTroca;

        public async Task ExecutarMovimentacao(Produto produto, int quantidade, TipoUnidade tipoUnidade, CustoProdutoValue custo)
        {
            produto.RemoverEstoque(quantidade, tipoUnidade);
            var movimentacao = new MovimentacaoEstoque(produto.Id, DateTime.Now, tipoUnidade, Tipo, quantidade, custo);
            await _movEstoque.AdicionarAsync(movimentacao);
        }
    }
}

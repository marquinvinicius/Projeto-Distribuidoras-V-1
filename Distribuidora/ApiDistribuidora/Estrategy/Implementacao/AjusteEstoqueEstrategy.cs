using ApiDistribuidora.Estrategy.Interface;
using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Entidades;
using BackDistribuidora.Entidades.Enums;
using Distribuidora.Back.Entidades.Object_Values;

namespace ApiDistribuidora.Estrategy.Implementacao
{
    public class AjusteEstoqueEstrategy : IMovimentacaoEstrategy
    {
        private readonly IMovimentacaoEstoqueRepository _movEstoque;
        public AjusteEstoqueEstrategy(IMovimentacaoEstoqueRepository movEstoque)
        {
            _movEstoque = movEstoque;
        }
        public TipoTransacao Tipo => TipoTransacao.AjusteEstoque;

        public async Task ExecutarMovimentacao(Produto produto, int novoSaldo, TipoUnidade tipoUnidade, CustoProdutoValue custo)
        {
            int delta = novoSaldo - produto.QuantidadeEstoque.Valor;

            produto.AjustarEstoque(novoSaldo);

            var movimentacao = new MovimentacaoEstoque(produto.Id, DateTime.Now, tipoUnidade, Tipo, delta, custo);

            await _movEstoque.AdicionarAsync(movimentacao);
        }
    }
}

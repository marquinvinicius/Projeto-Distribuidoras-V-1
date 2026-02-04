using ApiDistribuidora.Estrategy.Interface;
using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Entidades;
using BackDistribuidora.Entidades.Enums;
using Distribuidora.Back.Entidades.Object_Values;
using System.Threading.Tasks;

namespace ApiDistribuidora.Estrategy.Implementacao
{
    public class EntradaEstrategy : IMovimentacaoEstrategy
    {
        private readonly IMovimentacaoEstoqueRepository _movEstoque;

        public EntradaEstrategy(IMovimentacaoEstoqueRepository movEstoque)
        {
            _movEstoque = movEstoque;
        }

        public TipoTransacao Tipo => TipoTransacao.Entrada;

        public async Task ExecutarMovimentacao(Produto produto, int quantidade, TipoUnidade tipoUnidade, CustoProdutoValue custo)
        {
            produto.AdicionarEstoque(quantidade, tipoUnidade);
            var movimentacao = new MovimentacaoEstoque(produto.Id ,DateTime.Now, tipoUnidade, Tipo, quantidade, custo);

            await _movEstoque.AdicionarAsync(movimentacao);
        }
    }
}

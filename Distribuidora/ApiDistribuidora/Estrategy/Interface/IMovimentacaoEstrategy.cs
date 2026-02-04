using BackDistribuidora.Entidades;
using BackDistribuidora.Entidades.Enums;
using Distribuidora.Back.Entidades.Object_Values;

namespace ApiDistribuidora.Estrategy.Interface
{
    public interface IMovimentacaoEstrategy
    {
        TipoTransacao Tipo { get; }
        Task ExecutarMovimentacao(Produto produto, int quantidade, TipoUnidade tipoUnidade, CustoProdutoValue custo);
    }
}

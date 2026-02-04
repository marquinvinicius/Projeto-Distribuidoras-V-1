using BackDistribuidora.Entidades.Enums;
using BackDistribuidora.Entidades.Interfaces;
using Distribuidora.Back.Entidades.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Entidades
{
    public class MovimentacaoEstoque : ITemporalEntity
    {
        public int Id { get; private set; }
        public int ProdutoId { get; private set; }
        public Produto Produto { get; private set; }
        public DateTime DataMovimentacao { get; private set; }

        public TipoUnidade TipoUnidade { get; private set; }

        public TipoTransacao TipoTransacao { get; private set; }    
        public int Quantidade { get; private set; }

        public CustoProdutoValue PrecoUnitario { get; private set; }

        protected MovimentacaoEstoque() {}

        public MovimentacaoEstoque(int produtoId, DateTime dataMovimentacao, TipoUnidade tipoUnidade, 
            TipoTransacao tipoTransacao, int quantidade, CustoProdutoValue custo)
        {
            if (produtoId <= 0)
                throw new ArgumentException("O ID do produto deve ser maior que zero.", nameof(produtoId));
            if (quantidade <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.", nameof(quantidade));
            ProdutoId = produtoId;
            DataMovimentacao = dataMovimentacao;
            TipoUnidade = tipoUnidade;
            TipoTransacao = tipoTransacao;
            Quantidade = quantidade;
            PrecoUnitario = custo;
        }
        public override string ToString()
        {
            return $"Movimentação de Estoque - Produto ID: {ProdutoId}, Data: {DataMovimentacao}, Tipo Unidade: {TipoUnidade}, " +
                   $"Tipo Transação: {TipoTransacao}, Quantidade: {Quantidade}, Preço Unitário: {PrecoUnitario}";
        }
    }
}

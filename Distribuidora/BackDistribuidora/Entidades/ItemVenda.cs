using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Entidades
{
    public class ItemVenda
    {
        public int Id { get; private set; }
        public int ProdutoId { get; internal set; }

        public int Quantidade { get; internal set; }
        public decimal PrecoVenda { get; internal set; }
        public decimal PrecoCusto { get; internal set; }

        public decimal SubTotal => Quantidade * PrecoVenda;
        public int VendaId { get; internal set; }
        public Venda Venda { get; internal set; }

        protected ItemVenda() { }
        public ItemVenda(int produtoid, int quantidade, decimal precoVenda, decimal precoCusto)
        {
            if (quantidade <= 0) throw new ArgumentException("Quantidade deve ser maior que zero.");
            if (precoVenda < 0) throw new ArgumentException("Preço de venda não pode ser negativo.");
            if (precoCusto < 0) throw new ArgumentException("Preço do produto não pode ser negativo.");
            ProdutoId = produtoid;
            Quantidade = quantidade;
            PrecoVenda = precoVenda;
            PrecoCusto = precoCusto;
        }

        public void AtualizarQuantidade(int novaQuantidade)
        {
            if (novaQuantidade <= 0) throw new ArgumentException("Nova quantidade deve ser maior que zero.");
            Quantidade = novaQuantidade;
        }

    }
}

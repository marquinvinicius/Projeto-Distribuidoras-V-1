using BackDistribuidora.Entidades.Enums;
using Distribuidora.Back.Entidades.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Entidades
{
    public class Produto
    {
        public Produto(NomeProdutoValue nomeProduto, QuantidadeFardoValue quantidadeFardo, 
            CustoProdutoValue precoCusto, int marcaId, int categoriaId)
        {
            if (marcaId <= 0)
                throw new ArgumentException("Marca inválida.", nameof(marcaId));
            if (categoriaId <= 0)
                throw new ArgumentException("Categoria inválida.", nameof(categoriaId));
            NomeProduto = nomeProduto;
            QuantidadeFardo = quantidadeFardo;
            PrecoCusto = precoCusto;
            MarcaId = marcaId;
            CategoriaId = categoriaId;
            QuantidadeEstoque = new EstoqueProdutoValue(0);
        }

        public int Id { get; private set; }
        public NomeProdutoValue NomeProduto { get; internal set; }

        public QuantidadeFardoValue QuantidadeFardo { get; internal set; }
        public EstoqueProdutoValue QuantidadeEstoque { get; private set; }
        public CustoProdutoValue PrecoCusto { get; internal set; }

        public int MarcaId { get; internal set; }
        public Marca Marca { get; private set; }
        public int CategoriaId { get; internal set; }
        public Categoria Categoria { get; private set; }

        public ICollection<MovimentacaoEstoque> MovimentacoesEstoque { get; private set; }

        internal Produto() { }

        public void AtualizarNomeProduto(NomeProdutoValue novoNome)
        {
            if (novoNome == null)
                throw new ArgumentException("O novo nome do produto não pode ser nulo.");
            NomeProduto = novoNome;
        }
        public void AtualizarQuantidadeFardo(QuantidadeFardoValue novaQuantidadeFardo)
        {
            if (novaQuantidadeFardo.Valor <= 0)
                throw new ArgumentException("A nova quantidade por fardo deve ser maior que zero.");
            QuantidadeFardo = novaQuantidadeFardo;
        }

        public void AtualizarCategoria(int novaCategoriaId)
        {
            if (novaCategoriaId <= 0)
                throw new ArgumentException("A nova categoria deve ser válida.");
            CategoriaId = novaCategoriaId;
        }
        public void AtualizarMarca(int novaMarcaId)
        {
            if (novaMarcaId <= 0)
                throw new ArgumentException("A nova marca deve ser válida.");
            MarcaId = novaMarcaId;
        }
        public void AtualizarPrecoCusto(CustoProdutoValue novoPrecoCusto)
        {
            if (novoPrecoCusto.Valor <= 0)
                throw new ArgumentException("O novo preço de custo deve ser maior que zero.");
            PrecoCusto = novoPrecoCusto;
        }

        public void AdicionarEstoque(int quantidade , TipoUnidade tipoUnidade)
        {
            int conversao = quantidade * (tipoUnidade == TipoUnidade.Fardo ? QuantidadeFardo.Valor : 1);
            int novaQuantidade = QuantidadeEstoque.Valor + conversao;
            QuantidadeEstoque = new EstoqueProdutoValue(novaQuantidade);
        }
        public void RemoverEstoque(int quantidade, TipoUnidade tipoUnidade)
        {
            int conversao = quantidade * (tipoUnidade == TipoUnidade.Fardo ? QuantidadeFardo.Valor : 1);
            int novaQuantidade = QuantidadeEstoque.Valor - conversao;
            if (novaQuantidade < 0)
                throw new InvalidOperationException("Não é possível remover mais estoque do que o disponível.");
            QuantidadeEstoque = new EstoqueProdutoValue(novaQuantidade);
        }
        public void AjustarEstoque(int novoSaldo)
        {
            if (novoSaldo < 0)
                throw new ArgumentException("O saldo ajustado não pode ser negativo.", nameof(novoSaldo));
            QuantidadeEstoque = new EstoqueProdutoValue(novoSaldo);
        }
        public override string ToString()
        {
            return $"ID:{Id}\n" +
                   $"Produto: {NomeProduto}\n" +
                   $"Quantidade por Fardo: {QuantidadeFardo}\n" +
                   $"Preço de Custo: {PrecoCusto}\n" +
                   $"MarcaId: {MarcaId}\n" +
                   $"CategoriaId: {CategoriaId}\n" +
                   $"Quantidade em Estoque: {QuantidadeEstoque}";
        }
    }
}
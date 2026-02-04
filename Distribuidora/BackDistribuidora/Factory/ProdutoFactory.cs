using BackDistribuidora.Builder;
using BackDistribuidora.Entidades;
using Distribuidora.Back.Entidades.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Factory
{
    public class ProdutoFactory
    {
            public Produto CriarProduto(Produto produto, Categoria categoria, Marca marca)
            {
                return new ProdutoBuilder()
                    .ComNome(produto.NomeProduto)
                    .ComQuantidadeFardo(produto.QuantidadeFardo)
                    .ComPrecoCusto(produto.PrecoCusto)
                    .ComMarcaId(marca.Id)
                    .ComCategoriaId(categoria.Id)
                    .Criar();
            }
            public void AtualizarProduto(Produto produtoExistente,
                NomeProdutoValue novoNome, QuantidadeFardoValue novaQuantidadeFardo,
                 CustoProdutoValue novoPrecoCusto,
                int categoriaId, int marcaId)
            {
                if (produtoExistente == null)
                    throw new ArgumentNullException(nameof(produtoExistente), "Produto não pode ser nulo");
            }
    }
}

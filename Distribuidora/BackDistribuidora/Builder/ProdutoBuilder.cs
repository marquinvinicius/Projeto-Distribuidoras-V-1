using BackDistribuidora.Entidades;
using Distribuidora.Back.Entidades.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Builder;

public class ProdutoBuilder
{
    private readonly Produto _produto = new();

    public ProdutoBuilder ComNome(NomeProdutoValue nome) { _produto.NomeProduto = nome; return this; }
    public ProdutoBuilder ComPrecoCusto(CustoProdutoValue custo) { _produto.PrecoCusto = custo; return this; }
    public ProdutoBuilder ComQuantidadeFardo(QuantidadeFardoValue quantidadeFardo) { _produto.QuantidadeFardo = quantidadeFardo; return this; }
    public ProdutoBuilder ComMarcaId(int marcaId) { _produto.MarcaId = marcaId; return this; }
    public ProdutoBuilder ComCategoriaId(int categoriaId) { _produto.CategoriaId = categoriaId; return this; }
    public Produto Criar() => _produto;
}

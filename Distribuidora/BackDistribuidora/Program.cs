using BackDistribuidora.Builder;
using BackDistribuidora.Entidades;
using BackDistribuidora.Entidades.Enums;
using Distribuidora.Back.Entidades.Object_Values;

var produtoBuilder = new ProdutoBuilder();

Produto produto = produtoBuilder
  .ComNome(new NomeProdutoValue("Produto Exemplo"))
  .ComQuantidadeFardo(new QuantidadeFardoValue(10))
  .ComPrecoCusto(new CustoProdutoValue(50.0m))
  .ComMarcaId(1)
  .ComCategoriaId(2)
  .Criar();

produto.AtualizarQuantidadeFardo(new QuantidadeFardoValue(15));
Console.WriteLine(produto.ToString());

PrecoVenda precoVenda = new PrecoVenda(produto, 75.0m, DateTime.Now, null);
ItemVenda itemVenda = new ItemVenda(produto.Id, 5, precoVenda.PrecoUnitario, produto.PrecoCusto.Valor);
VendaBuilder vendaBuilder = new VendaBuilder();
MovimentacaoEstoque movimentacaoEstoque = new MovimentacaoEstoque
    (
        1,
        dataMovimentacao: DateTime.Now,
        tipoUnidade: TipoUnidade.Fardo,
        tipoTransacao: TipoTransacao.SaidaVenda,
        quantidade: 5,
        new CustoProdutoValue(15)
    );
vendaBuilder
    .AdicionarItem(itemVenda)
    .ComDataVenda(DateTime.Now)
    .Criar();

Console.WriteLine(movimentacaoEstoque.ToString());
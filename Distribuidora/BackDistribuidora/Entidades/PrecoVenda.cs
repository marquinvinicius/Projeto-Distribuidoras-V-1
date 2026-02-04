using Distribuidora.Back.Entidades.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Entidades
{
    public class PrecoVenda
    {
        public int Id { get; private set; }
        public int ProdutoId { get; private set; }
        public decimal PrecoUnitario { get;  private set; }
        public decimal PrecoFardo { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }
        public Produto Produto { get; private set; }
        protected PrecoVenda() { }

        public PrecoVenda(Produto produto, decimal precoUnitario, DateTime dataInicio, DateTime? dataFim)
        {
            if (precoUnitario < 0)
                throw new ArgumentOutOfRangeException(nameof(precoUnitario), "O preço unitário não pode ser negativo.");

            ProdutoId = produto.Id;
            PrecoUnitario = precoUnitario;
            PrecoFardo = precoUnitario * produto.QuantidadeFardo.Valor;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public void EncerrarPreco(DateTime dataFim)
        {

            if (dataFim <= DataInicio)
                throw new ArgumentException("A data de fim deve ser posterior à data de início.", nameof(dataFim));
            if (DataFim != null)
                throw new InvalidOperationException("O preço já foi encerrado.");
            DataFim = dataFim;
        }
        public override string ToString()
        {
            return $"ProdutoId: {ProdutoId}, PrecoUnitario: {PrecoUnitario:C}, " + $"PrecoFardo: {PrecoFardo:C}," +
                $" DataInicio: {DataInicio}, DataFim: {(DataFim.HasValue ? DataFim.Value.ToString() : "Ativo")}";
        }
    }
}

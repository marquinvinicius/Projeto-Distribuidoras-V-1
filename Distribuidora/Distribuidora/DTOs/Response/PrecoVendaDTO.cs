using System.Text.Json.Serialization;

namespace ApiDistribuidora.DTOs.Response
{
    public class PrecoVendaDTO
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public decimal PrecoUnitario { get; set; }

        public decimal PrecoFardo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }
    }
}

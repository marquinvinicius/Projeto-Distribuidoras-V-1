using ApiDistribuidora.DTOs.Filters;
using BackDistribuidora.Entidades;
using BackDistribuidora.Entidades.Enums;

namespace ApiDistribuidora.DTOs.Input
{
    public class MovimentacaoEstoqueInputDTO 
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public TipoTransacao TipoTransacao { get; set; }
        public TipoUnidade TipoUnidade{ get; set; }
    }
}

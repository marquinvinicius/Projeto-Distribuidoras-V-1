using BackDistribuidora.Entidades.Enums;

namespace ApiDistribuidora.DTOs.Filters
{
    public class MovimentacaoFilterInput : BaseFilterInput
    {
        public int? ProdutoId { get; set; }
        
        public TipoTransacao? TipoTransacao { get; set; }
    }
}

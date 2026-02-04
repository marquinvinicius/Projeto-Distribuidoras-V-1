using BackDistribuidora.Entidades.Enums;

namespace ApiDistribuidora.DTOs.Filters
{
    public class MovimentacaoFilterInput : BaseFilterInput
    {
        public int? ProdutoId { get; set; }
        public int? CategoriaId { get; set; }
        public int? MarcaId { get; set; }
        public TipoTransacao? TipoTransacao { get; set; }
        public TipoUnidade? TipoUnidade { get; set; }
    }
}

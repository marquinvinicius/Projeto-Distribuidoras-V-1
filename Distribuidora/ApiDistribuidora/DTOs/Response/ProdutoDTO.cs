namespace ApiDistribuidora.DTOs.Response
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Estoque { get; set; }

        public int QuantidadeFardo { get; set; }
        public string? MarcaId { get; set; }
        public string MarcaNome { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; } = string.Empty;
    }
}

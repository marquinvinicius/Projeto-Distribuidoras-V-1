namespace ApiDistribuidora.DTOs.Response
{
    public class ItemVendaDTO
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public string ProdutoNome { get; set; } = string.Empty;

        public decimal PrecoCusto { get; set; }

        public decimal PrecoVenda { get; set; }

        public int Quantidade { get; set; }
        public decimal SubTotal => PrecoVenda * Quantidade; 
    }
}

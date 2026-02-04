namespace ApiDistribuidora.DTOs.Response
{
    public class VendaDTO
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public List<ItemVendaDTO> Itens { get; set; }
        public decimal Total { get; set; }
    }
}

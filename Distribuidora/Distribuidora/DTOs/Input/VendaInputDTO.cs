using System.ComponentModel.DataAnnotations;

namespace ApiDistribuidora.DTOs.Input
{
    public class VendaInputDTO
    {
        [Required(ErrorMessage = "É necessário informar pelo menos um item na venda")]
        public List<ItemVendaInputDTO> Itens { get; set; } = new List<ItemVendaInputDTO>();

        public DateTime DataVenda { get; set; } = DateTime.Now;
    }
}

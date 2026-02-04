using System.ComponentModel.DataAnnotations;

namespace ApiDistribuidora.DTOs.Input
{
    public class ItemVendaInputDTO
    {
        [Required(ErrorMessage = "Produto obrigatório")]
        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "Quantidade obrigatória")]
        public int Quantidade { get; set; }
    }
}

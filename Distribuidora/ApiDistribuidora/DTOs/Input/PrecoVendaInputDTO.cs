using ApiDistribuidora.Validate;
using System.ComponentModel.DataAnnotations;

namespace ApiDistribuidora.DTOs.Input
{
    public class PrecoVendaInputDTO
    {
        [Required]
        public int ProdutoId { get; set; }

        [Required]
        [ValidarPreco(ErrorMessage = "Preço deve ser maior que 0")]
        public decimal ValorVenda { get; set; }
    }
}

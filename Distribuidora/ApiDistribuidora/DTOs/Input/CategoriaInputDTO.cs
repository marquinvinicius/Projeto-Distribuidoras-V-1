using System.ComponentModel.DataAnnotations;

namespace ApiDistribuidora.DTOs.Input
{
    public class CategoriaInputDTO
    {
        [Required(ErrorMessage = "O nome da categoria é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome da categoria deve ter no maximo 100 caracteres")]
        public string Nome { get; set; } = string.Empty;
    }
}

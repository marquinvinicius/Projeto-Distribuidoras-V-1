using System.ComponentModel.DataAnnotations;

namespace ApiDistribuidora.DTOs.Input
{
    public class MarcaInputDTO
    {
        [Required(ErrorMessage =" O nome da marca é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome deve ter no maximo 100 caracteres")]
        public string Nome { get; set; } = string.Empty;    
    }
}

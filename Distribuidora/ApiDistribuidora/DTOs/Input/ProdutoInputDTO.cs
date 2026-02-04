using System.ComponentModel.DataAnnotations;

namespace ApiDistribuidora.DTOs.Input
{
    public class ProdutoInputDTO
    {

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre {2} e {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A quantidade por fardo é obrigatória.")]
        public int QuantidadeFardo { get; set; }
        [Required(ErrorMessage = "O preço de custo é obrigatório.")]
        public decimal PrecoCusto { get; set; }

        [Required(ErrorMessage = "A categoria é obrigatória.")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Marca é obrigatória")]
        public int MarcaId { get; set; }

    }
}

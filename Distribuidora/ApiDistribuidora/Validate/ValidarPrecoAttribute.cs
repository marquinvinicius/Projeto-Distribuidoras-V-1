using System.ComponentModel.DataAnnotations;

namespace ApiDistribuidora.Validate
{
    public class ValidarPrecoAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is decimal preco && preco >= 0)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("O preço deve ser um valor decimal não negativo.");
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models.Validaciones
{
    public class PrimeraLetraMayusculaAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //Verificar si es nulo
            if (value == null || string.IsNullOrEmpty(value.ToString())) {
                return ValidationResult.Success;
            }
            var primeraLetra = value.ToString()[0].ToString();
            //Verificar si primera letra es mayúscula
            if (primeraLetra != primeraLetra.ToUpper())
            {
                return new ValidationResult("La primera letra debe ser mayúscula");
            }
            return ValidationResult.Success;
        }
    }
}

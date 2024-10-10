using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo {0} es requerido")] // Atributo que indica que este campo es obligatorio.
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electrónico válido")] // Atributo que valida que el valor es una dirección de correo electrónico válida.
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")] // Atributo que indica que este campo es obligatorio.
        [DataType(DataType.Password)] // Atributo que indica que el campo debe ser tratado como una contraseña, lo que generalmente oculta el texto ingresado.
        public string Password { get; set; }


        public bool Recuerdame { get; set; }
    }
}

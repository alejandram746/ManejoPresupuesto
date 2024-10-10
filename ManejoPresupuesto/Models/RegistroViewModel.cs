// Define el namespace ManejoPresupuesto.Models, que agrupa las clases relacionadas con los modelos de datos de la aplicación.
using System.ComponentModel.DataAnnotations; // Importa el namespace que contiene atributos de validación de datos para el modelo.

namespace ManejoPresupuesto.Models
{
    // Define una clase llamada `RegistroViewModel`.
    // Los ViewModels son modelos que se utilizan para pasar datos entre el controlador y la vista.
    public class RegistroViewModel
    {
        // Define una propiedad pública de tipo string llamada `Email`.
        // Esta propiedad almacenará el correo electrónico ingresado por el usuario.
        [Required(ErrorMessage = "El campo {0} es requerido")] // Atributo que indica que este campo es obligatorio.
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electrónico válido")] // Atributo que valida que el valor es una dirección de correo electrónico válida.
        public string Email { get; set; }

        // Define una propiedad pública de tipo string llamada `Password`.
        // Esta propiedad almacenará la contraseña ingresada por el usuario.
        [Required(ErrorMessage = "El campo {0} es requerido")] // Atributo que indica que este campo es obligatorio.
        [DataType(DataType.Password)] // Atributo que indica que el campo debe ser tratado como una contraseña, lo que generalmente oculta el texto ingresado.
        public string Password { get; set; }
    }
}

// Declara un espacio de nombres llamado ManejoPresupuesto.Models.
// Este espacio de nombres se utiliza para agrupar las clases relacionadas con los modelos de datos en la aplicación.
namespace ManejoPresupuesto.Models
{
    // Define una clase llamada Usuario que representa la información de un usuario en la aplicación.
    public class Usuario
    {
        // Propiedad para almacenar el identificador único del usuario.
        // Se utiliza para diferenciar cada usuario en la base de datos.
        public int Id { get; set; }

        // Propiedad para almacenar la dirección de correo electrónico del usuario.
        // Es una cadena de texto que contiene el email del usuario.
        public string Email { get; set; }

        // Propiedad para almacenar el correo electrónico normalizado del usuario.
        // El correo electrónico normalizado es una versión estandarizada del email, utilizada para búsquedas y comparaciones.
        public string EmailNormalizado { get; set; }

        // Propiedad para almacenar el hash de la contraseña del usuario.
        // El hash de la contraseña es una representación cifrada de la contraseña real para seguridad.
        public string PasswordHash { get; set; }
    }
}

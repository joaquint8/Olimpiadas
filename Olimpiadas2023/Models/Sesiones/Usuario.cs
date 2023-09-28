using Olimpiadas2023.Models.Personales;
using System.ComponentModel.DataAnnotations;

namespace Olimpiadas2023.Models.Sesiones
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Clave { get; set; }
        public int RolId { get; set; }
        public Rol? Rol { get; set; }
        public Empleado? Empleado { get; set; }
    }
}

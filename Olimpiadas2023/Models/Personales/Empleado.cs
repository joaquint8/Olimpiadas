using Olimpiadas2023.Enum;
using Olimpiadas2023.Models.Sesiones;
using System.Reflection.Metadata.Ecma335;

namespace Olimpiadas2023.Models.Personales
{
    public class Empleado : Persona
    {
        public int EmpleadoId { get; set; }
        public TipoCargo TipoCargo { get; set; }
        public string Horarios { get; set; }
        public TipoProfesion Profesion { get; set; }
        public string? Especializacion { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? UsuarioEmpleado { get; set; }
        
    }
}

using Olimpiadas2023.Enum;
using System.Reflection.Metadata.Ecma335;

namespace Olimpiadas2023.Models.Personales
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public TipoCargo TipoCargo { get; set; }
        public string Horarios { get; set; }
        public TipoProfesion Profesion { get; set; }
        public string? Especializacion { get; set; }
        public Persona? Persona { get; set; }
    }
}

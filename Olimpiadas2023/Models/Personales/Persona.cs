using Olimpiadas2023.Enum;
using System.Reflection.Metadata.Ecma335;

namespace Olimpiadas2023.Models.Personales
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public TipoGrupoSanguineo GrupoSanguineo { get; set; }
        public string Telefono { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado? Empleado { get; set; }

        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }
    }
}

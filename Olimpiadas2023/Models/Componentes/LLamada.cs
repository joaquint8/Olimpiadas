using Olimpiadas2023.Enum;
using Olimpiadas2023.Models.Personales;
using System.Reflection.Metadata.Ecma335;

namespace Olimpiadas2023.Models.Componentes
{
    public class LLamada
    {
        public int LlamadaId { get; set; }
        public TipoLLamada tipoLLamada { get; set; }
        public DateTime Fecha { get; set; }
        public TipoOrigenLlamado origenLlamado { get; set; }
        public bool Atendio { get; set; }

        public int AreaId { get; set; }
        public Area? Area { get; set; }

        public int PacienteId { get; set; }
        public Paciente? PacienteAsignado { get; set; }

        public int HabitacionId { get; set; }
        public Habitacion? HabitacionAsignada { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado? EmpleadoAsignado { get; set; }

    }
}

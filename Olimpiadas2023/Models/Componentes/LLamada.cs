using Olimpiadas2023.Enum;
using Olimpiadas2023.Models.Personales;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Olimpiadas2023.Models.Componentes
{
    public class Llamada
    {
        public int LlamadaId { get; set; }
        public TipoLLamada tipoLLamada { get; set; }
        public DateTime Fecha { get; set; }
        public TipoOrigenLlamado origenLlamado { get; set; }
        public bool Atendio { get; set; }

        public int HabitacionId { get; set; }
        public Habitacion? HabitacionLlamada { get; set; }

        [InverseProperty("PacienteArea")]
        public int PersonaId { get; set; }
        public Paciente? PacienteAsignado { get; set; }

        [InverseProperty("EmpleadoArea")]
        public int EmpleadoId { get; set; }
        public Empleado? EmpleadoAsignado { get; set; }

    }
}

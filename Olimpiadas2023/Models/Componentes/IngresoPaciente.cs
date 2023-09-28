using Olimpiadas2023.Enum;
using Olimpiadas2023.Models.Personales;

namespace Olimpiadas2023.Models.Componentes
{
    public class IngresoPaciente
    {
        public int IngresoPacienteId { get; set; }
        public string Descripcion { get; set; }
        public TipoImportancia Importancia { get; set; }

        public int HabitacionId { get; set; }
        public Habitacion? Habitacion { get; set; }
        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }

    }
}

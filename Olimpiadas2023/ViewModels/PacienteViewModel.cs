using Olimpiadas2023.Models.Componentes;
using Olimpiadas2023.Models.Personales;
using Olimpiadas2023.Models;

namespace Olimpiadas2023.ViewModels
{
    public class PacienteViewModel : PersonaViewModel
    {
        public int HistorialMedico { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaAlta { get; set; }
        public List<Alergia>? Alergias { get; set; }
        public List<Enfermedad>? Enfermedades { get; set; }
        public List<Medicamento>? Medicamentos { get; set; }
        public int HistorialMedicoId { get; set; }
        public HistorialMedico? HistorialMedicos { get; set; }
        public Area? AreaAsignada { get; set; }
    }
}

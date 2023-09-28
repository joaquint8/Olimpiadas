using Olimpiadas2023.Enum;

namespace Olimpiadas2023.ViewModels
{
    public class EmpleadoViewModel : PersonaViewModel
    {
        public int EmpleadoId { get; set; }
        public TipoCargo TipoCargo { get; set; }
        public string Horarios { get; set; }
        public TipoProfesion Profesion { get; set; }
        public string? Especializacion { get; set; }
    }
}

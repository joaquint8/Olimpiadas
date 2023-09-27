using Olimpiadas2023.Models.Personales;

namespace Olimpiadas2023.Models.Componentes
{
    public class Enfermedad
    {
        public int EnfermedadId { get; set; }
        public string? Descripcion { get; set; }  
        public Paciente? Paciente { get; set; }
    }
}

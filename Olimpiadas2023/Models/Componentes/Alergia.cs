using Olimpiadas2023.Models.Personales;

namespace Olimpiadas2023.Models.Componentes
{
    public class Alergia
    {
        public int AlergiaId { get; set; }
        public string? Descripcion { get; set; }
        public Paciente? Paciente { get; set; }
    }
}

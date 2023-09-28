using Olimpiadas2023.Enum;

namespace Olimpiadas2023.Models.Componentes
{
    public class Area
    {
        public int AreaId { get; set; }
        public TipoAreas TipoArea { get; set; }
        public string  TipoAcceso { get; set; }
        public int HabitacionId { get; set; }
        List<Habitacion>? Habitaciones { get; set; }
    }
}

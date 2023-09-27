namespace Olimpiadas2023.Models.Componentes
{
    public class Sintoma
    {
        public int SintomaId { get; set; }
        public string? Descripcion { get; set; }
        public HistorialMedico? HistorialMedico { get; set; }
    }
}

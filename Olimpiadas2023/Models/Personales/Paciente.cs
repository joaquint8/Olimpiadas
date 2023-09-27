namespace Olimpiadas2023.Models.Personales
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public int HistorialMedico { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaAlta { get; set; }
        public Persona? Persona { get; set; }
    }
}

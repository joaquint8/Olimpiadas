using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Olimpiadas2023.Models.Componentes;
using System.Reflection.Metadata.Ecma335;

namespace Olimpiadas2023.Models.Personales
{
    public class Paciente : Persona
    {
        public int PacienteId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaAlta { get; set; }
        public List<Alergia>? Alergias { get; set; }
        public List<Enfermedad>? Enfermedades { get; set; }
        public  List<Medicamento>? Medicamentos  { get; set; }
        public HistorialMedico? HistorialMedicos { get; set; }
        public List<IngresoPaciente> HistorialIngreso { get; set; }
    }
}

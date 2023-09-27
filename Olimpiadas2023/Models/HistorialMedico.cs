using Olimpiadas2023.Models.Componentes;
using Olimpiadas2023.Models.Personales;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Olimpiadas2023.Models
{
    public class HistorialMedico
    {
        public int HistorialMedicoId { get; set; }
        public List<Sintoma>? Sintomas { get; set; }
        public List<Tratamiento>? Tratamientos { get; set; }
        public List<ResultadoExamen>? ResultadosExamenes { get; set; }
        public string Diagnostico { get; set; }
        public Paciente? Paciente { get; set; }

    }
}

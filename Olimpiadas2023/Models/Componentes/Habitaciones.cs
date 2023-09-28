using Microsoft.EntityFrameworkCore;
using Olimpiadas2023.Enum;
using System.ComponentModel.DataAnnotations;

namespace Olimpiadas2023.Models.Componentes
{
    [Index(nameof(NumeroHabitacion))]
    public class Habitacion
    {
        public int HabitacionId { get; set; }
        [Required]
        public int NumeroHabitacion { get; set; }
        public TipoHabitacion TipoHabitacion { get; set; }
        public EstadoHabitacion EstadoHabitacion { get; set; }
        public int Capacidad { get; set; }
        public string? Descripcion { get; set; }

    }
}

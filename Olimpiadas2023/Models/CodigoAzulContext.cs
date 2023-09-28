using Microsoft.EntityFrameworkCore;
using Olimpiadas2023.Models.Componentes;
using Olimpiadas2023.Models.Personales;

namespace Olimpiadas2023.Models
{
    public class CodigoAzulContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }

        public CodigoAzulContext(DbContextOptions<CodigoAzulContext> options)
           : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Persona>()
                .HasDiscriminator<int>("TipoPersona")
                .HasValue<Empleado>(1)
                .HasValue<Paciente>(2);
            //configuracion de los enums
            modelBuilder
               .Entity<Persona>()
               .Property(p => p.GrupoSanguineo)
               .HasConversion<string>()
               .HasMaxLength(255);

            modelBuilder
              .Entity<Empleado>()
              .Property(e => e.Profesion)
              .HasConversion<string>()
              .HasMaxLength(255);
            modelBuilder
              .Entity<Empleado>()
              .Property(e => e.TipoCargo)
              .HasConversion<string>()
              .HasMaxLength(255);
            modelBuilder
              .Entity<Habitacion>()
              .Property(h => h.TipoHabitacion)
              .HasConversion<string>()
              .HasMaxLength(255);
            modelBuilder
              .Entity<Habitacion>()
              .Property(h => h.EstadoHabitacion)
              .HasConversion<string>()
              .HasMaxLength(255);
        }
    }

}

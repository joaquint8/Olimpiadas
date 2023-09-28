using Microsoft.EntityFrameworkCore;
using Olimpiadas2023.Models.Componentes;
using Olimpiadas2023.Models.Personales;
using Olimpiadas2023.Models.Sesiones;
using System.Reflection.Metadata.Ecma335;

namespace Olimpiadas2023.Models
{
    public class CodigoAzulContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<IngresoPaciente> IngresoPacientes { get; set; }
        public DbSet<Area> areas { get; set; }
        public DbSet<LLamada> lLamadas { get; set; }
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
            modelBuilder
              .Entity<IngresoPaciente>()
              .Property(i => i.Importancia)
              .HasConversion<string>()
              .HasMaxLength(255);
            modelBuilder
             .Entity<Area>()
             .Property(a => a.TipoArea)
             .HasConversion<string>()
             .HasMaxLength(255);
            modelBuilder
             .Entity<LLamada>()
             .Property(l => l.tipoLLamada)
             .HasConversion<string>()
             .HasMaxLength(255);
            modelBuilder
             .Entity<LLamada>()
             .Property(l => l.origenLlamado)
             .HasConversion<string>()
             .HasMaxLength(255);
        }
    }

}

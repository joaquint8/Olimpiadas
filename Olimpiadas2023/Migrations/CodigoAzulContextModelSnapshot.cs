﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Olimpiadas2023.Models;

#nullable disable

namespace Olimpiadas2023.Migrations
{
    [DbContext(typeof(CodigoAzulContext))]
    partial class CodigoAzulContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Alergia", b =>
                {
                    b.Property<int>("AlergiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlergiaId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacientePersonaId")
                        .HasColumnType("int");

                    b.HasKey("AlergiaId");

                    b.HasIndex("PacientePersonaId");

                    b.ToTable("Alergia");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Area", b =>
                {
                    b.Property<int>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AreaId"));

                    b.Property<string>("TipoAcceso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoArea")
                        .HasColumnType("int");

                    b.HasKey("AreaId");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Enfermedad", b =>
                {
                    b.Property<int>("EnfermedadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnfermedadId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacientePersonaId")
                        .HasColumnType("int");

                    b.HasKey("EnfermedadId");

                    b.HasIndex("PacientePersonaId");

                    b.ToTable("Enfermedad");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Habitacion", b =>
                {
                    b.Property<int>("HabitacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HabitacionId"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoHabitacion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("NumeroHabitacion")
                        .HasColumnType("int");

                    b.Property<string>("TipoHabitacion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("HabitacionId");

                    b.HasIndex("NumeroHabitacion");

                    b.ToTable("Habitaciones");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.HistorialMedico", b =>
                {
                    b.Property<int>("HistorialMedicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistorialMedicoId"));

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("HistorialMedicoId");

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.ToTable("HistorialMedico");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.IngresoPaciente", b =>
                {
                    b.Property<int>("IngresoPacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngresoPacienteId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HabitacionId")
                        .HasColumnType("int");

                    b.Property<int>("Importancia")
                        .HasColumnType("int");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("IngresoPacienteId");

                    b.HasIndex("HabitacionId");

                    b.HasIndex("PacienteId");

                    b.ToTable("IngresoPaciente");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Medicamento", b =>
                {
                    b.Property<int>("MedicamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicamentoId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacientePersonaId")
                        .HasColumnType("int");

                    b.HasKey("MedicamentoId");

                    b.HasIndex("PacientePersonaId");

                    b.ToTable("Medicamento");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.ResultadoExamen", b =>
                {
                    b.Property<int>("ResultadoExamenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResultadoExamenId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HistorialMedicoId")
                        .HasColumnType("int");

                    b.HasKey("ResultadoExamenId");

                    b.HasIndex("HistorialMedicoId");

                    b.ToTable("ResultadoExamen");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Sintoma", b =>
                {
                    b.Property<int>("SintomaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SintomaId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HistorialMedicoId")
                        .HasColumnType("int");

                    b.HasKey("SintomaId");

                    b.HasIndex("HistorialMedicoId");

                    b.ToTable("Sintoma");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Tratamiento", b =>
                {
                    b.Property<int>("TratamientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TratamientoId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HistorialMedicoId")
                        .HasColumnType("int");

                    b.HasKey("TratamientoId");

                    b.HasIndex("HistorialMedicoId");

                    b.ToTable("Tratamiento");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Personales.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonaId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrupoSanguineo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoPersona")
                        .HasColumnType("int");

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");

                    b.HasDiscriminator<int>("TipoPersona");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Sesiones.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RolId");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Sesiones.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolId")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Personales.Empleado", b =>
                {
                    b.HasBaseType("Olimpiadas2023.Models.Personales.Persona");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horarios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TipoCargo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasIndex("UsuarioId")
                        .IsUnique()
                        .HasFilter("[UsuarioId] IS NOT NULL");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Personales.Paciente", b =>
                {
                    b.HasBaseType("Olimpiadas2023.Models.Personales.Persona");

                    b.Property<int?>("AreaPacienteAreaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.HasIndex("AreaPacienteAreaId");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Alergia", b =>
                {
                    b.HasOne("Olimpiadas2023.Models.Personales.Paciente", "Paciente")
                        .WithMany("Alergias")
                        .HasForeignKey("PacientePersonaId");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Enfermedad", b =>
                {
                    b.HasOne("Olimpiadas2023.Models.Personales.Paciente", "Paciente")
                        .WithMany("Enfermedades")
                        .HasForeignKey("PacientePersonaId");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.HistorialMedico", b =>
                {
                    b.HasOne("Olimpiadas2023.Models.Personales.Paciente", "Paciente")
                        .WithOne("HistorialMedicos")
                        .HasForeignKey("Olimpiadas2023.Models.Componentes.HistorialMedico", "PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.IngresoPaciente", b =>
                {
                    b.HasOne("Olimpiadas2023.Models.Componentes.Habitacion", "Habitacion")
                        .WithMany()
                        .HasForeignKey("HabitacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olimpiadas2023.Models.Personales.Paciente", "Paciente")
                        .WithMany("HistorialIngreso")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habitacion");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Medicamento", b =>
                {
                    b.HasOne("Olimpiadas2023.Models.Personales.Paciente", "Paciente")
                        .WithMany("Medicamentos")
                        .HasForeignKey("PacientePersonaId");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.ResultadoExamen", b =>
                {
                    b.HasOne("Olimpiadas2023.Models.Componentes.HistorialMedico", "HistorialMedico")
                        .WithMany("ResultadosExamenes")
                        .HasForeignKey("HistorialMedicoId");

                    b.Navigation("HistorialMedico");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Sintoma", b =>
                {
                    b.HasOne("Olimpiadas2023.Models.Componentes.HistorialMedico", "HistorialMedico")
                        .WithMany("Sintomas")
                        .HasForeignKey("HistorialMedicoId");

                    b.Navigation("HistorialMedico");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.Tratamiento", b =>
                {
                    b.HasOne("Olimpiadas2023.Models.Componentes.HistorialMedico", "HistorialMedico")
                        .WithMany("Tratamientos")
                        .HasForeignKey("HistorialMedicoId");

                    b.Navigation("HistorialMedico");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Sesiones.Usuario", b =>
                {
                    b.HasOne("Olimpiadas2023.Models.Sesiones.Rol", "Rol")
                        .WithOne("Usuario")
                        .HasForeignKey("Olimpiadas2023.Models.Sesiones.Usuario", "RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Personales.Empleado", b =>
                {
                    b.HasOne("Olimpiadas2023.Models.Sesiones.Usuario", "UsuarioEmpleado")
                        .WithOne("Empleado")
                        .HasForeignKey("Olimpiadas2023.Models.Personales.Empleado", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioEmpleado");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Personales.Paciente", b =>
                {
                    b.HasOne("Olimpiadas2023.Models.Componentes.Area", "AreaPaciente")
                        .WithMany()
                        .HasForeignKey("AreaPacienteAreaId");

                    b.Navigation("AreaPaciente");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Componentes.HistorialMedico", b =>
                {
                    b.Navigation("ResultadosExamenes");

                    b.Navigation("Sintomas");

                    b.Navigation("Tratamientos");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Sesiones.Rol", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Sesiones.Usuario", b =>
                {
                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Olimpiadas2023.Models.Personales.Paciente", b =>
                {
                    b.Navigation("Alergias");

                    b.Navigation("Enfermedades");

                    b.Navigation("HistorialIngreso");

                    b.Navigation("HistorialMedicos");

                    b.Navigation("Medicamentos");
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olimpiadas2023.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habitaciones",
                columns: table => new
                {
                    HabitacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroHabitacion = table.Column<int>(type: "int", nullable: false),
                    TipoHabitacion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EstadoHabitacion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitaciones", x => x.HabitacionId);
                });

            migrationBuilder.CreateTable(
                name: "HistorialMedico",
                columns: table => new
                {
                    HistorialMedicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialMedico", x => x.HistorialMedicoId);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrupoSanguineo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoPersona = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: true),
                    TipoCargo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Horarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profesion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Especializacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteId = table.Column<int>(type: "int", nullable: true),
                    HistorialMedico = table.Column<int>(type: "int", nullable: true),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HistorialMedicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                    table.ForeignKey(
                        name: "FK_Personas_HistorialMedico_HistorialMedicoId",
                        column: x => x.HistorialMedicoId,
                        principalTable: "HistorialMedico",
                        principalColumn: "HistorialMedicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultadoExamen",
                columns: table => new
                {
                    ResultadoExamenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistorialMedicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultadoExamen", x => x.ResultadoExamenId);
                    table.ForeignKey(
                        name: "FK_ResultadoExamen_HistorialMedico_HistorialMedicoId",
                        column: x => x.HistorialMedicoId,
                        principalTable: "HistorialMedico",
                        principalColumn: "HistorialMedicoId");
                });

            migrationBuilder.CreateTable(
                name: "Sintoma",
                columns: table => new
                {
                    SintomaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistorialMedicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sintoma", x => x.SintomaId);
                    table.ForeignKey(
                        name: "FK_Sintoma_HistorialMedico_HistorialMedicoId",
                        column: x => x.HistorialMedicoId,
                        principalTable: "HistorialMedico",
                        principalColumn: "HistorialMedicoId");
                });

            migrationBuilder.CreateTable(
                name: "Tratamiento",
                columns: table => new
                {
                    TratamientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistorialMedicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tratamiento", x => x.TratamientoId);
                    table.ForeignKey(
                        name: "FK_Tratamiento_HistorialMedico_HistorialMedicoId",
                        column: x => x.HistorialMedicoId,
                        principalTable: "HistorialMedico",
                        principalColumn: "HistorialMedicoId");
                });

            migrationBuilder.CreateTable(
                name: "Alergia",
                columns: table => new
                {
                    AlergiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacientePersonaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alergia", x => x.AlergiaId);
                    table.ForeignKey(
                        name: "FK_Alergia_Personas_PacientePersonaId",
                        column: x => x.PacientePersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId");
                });

            migrationBuilder.CreateTable(
                name: "Enfermedad",
                columns: table => new
                {
                    EnfermedadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacientePersonaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfermedad", x => x.EnfermedadId);
                    table.ForeignKey(
                        name: "FK_Enfermedad_Personas_PacientePersonaId",
                        column: x => x.PacientePersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId");
                });

            migrationBuilder.CreateTable(
                name: "Medicamento",
                columns: table => new
                {
                    MedicamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacientePersonaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamento", x => x.MedicamentoId);
                    table.ForeignKey(
                        name: "FK_Medicamento_Personas_PacientePersonaId",
                        column: x => x.PacientePersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alergia_PacientePersonaId",
                table: "Alergia",
                column: "PacientePersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Enfermedad_PacientePersonaId",
                table: "Enfermedad",
                column: "PacientePersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_NumeroHabitacion",
                table: "Habitaciones",
                column: "NumeroHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_PacientePersonaId",
                table: "Medicamento",
                column: "PacientePersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_HistorialMedicoId",
                table: "Personas",
                column: "HistorialMedicoId",
                unique: true,
                filter: "[HistorialMedicoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoExamen_HistorialMedicoId",
                table: "ResultadoExamen",
                column: "HistorialMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sintoma_HistorialMedicoId",
                table: "Sintoma",
                column: "HistorialMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tratamiento_HistorialMedicoId",
                table: "Tratamiento",
                column: "HistorialMedicoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alergia");

            migrationBuilder.DropTable(
                name: "Enfermedad");

            migrationBuilder.DropTable(
                name: "Habitaciones");

            migrationBuilder.DropTable(
                name: "Medicamento");

            migrationBuilder.DropTable(
                name: "ResultadoExamen");

            migrationBuilder.DropTable(
                name: "Sintoma");

            migrationBuilder.DropTable(
                name: "Tratamiento");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "HistorialMedico");
        }
    }
}

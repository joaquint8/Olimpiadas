using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olimpiadas2023.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoTablasFaltantes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_HistorialMedico_HistorialMedicoId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_HistorialMedicoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "HistorialMedico",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "PacienteId",
                table: "Personas",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "HistorialMedicoId",
                table: "Personas",
                newName: "AreaPacienteAreaId");

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "HistorialMedico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "areas",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TipoAcceso = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_areas", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "IngresoPacientes",
                columns: table => new
                {
                    IngresoPacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Importancia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HabitacionId = table.Column<int>(type: "int", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresoPacientes", x => x.IngresoPacienteId);
                    table.ForeignKey(
                        name: "FK_IngresoPacientes_Habitaciones_HabitacionId",
                        column: x => x.HabitacionId,
                        principalTable: "Habitaciones",
                        principalColumn: "HabitacionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngresoPacientes_Personas_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "lLamadas",
                columns: table => new
                {
                    LlamadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoLLamada = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    origenLlamado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Atendio = table.Column<bool>(type: "bit", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    PacienteAsignadoPersonaId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lLamadas", x => x.LlamadaId);
                    table.ForeignKey(
                        name: "FK_lLamadas_Personas_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lLamadas_Personas_PacienteAsignadoPersonaId",
                        column: x => x.PacienteAsignadoPersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId");
                    table.ForeignKey(
                        name: "FK_lLamadas_areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_AreaPacienteAreaId",
                table: "Personas",
                column: "AreaPacienteAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_UsuarioId",
                table: "Personas",
                column: "UsuarioId",
                unique: true,
                filter: "[UsuarioId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialMedico_PacienteId",
                table: "HistorialMedico",
                column: "PacienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngresoPacientes_HabitacionId",
                table: "IngresoPacientes",
                column: "HabitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_IngresoPacientes_PacienteId",
                table: "IngresoPacientes",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_lLamadas_AreaId",
                table: "lLamadas",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_lLamadas_EmpleadoId",
                table: "lLamadas",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_lLamadas_PacienteAsignadoPersonaId",
                table: "lLamadas",
                column: "PacienteAsignadoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialMedico_Personas_PacienteId",
                table: "HistorialMedico",
                column: "PacienteId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Usuarios_UsuarioId",
                table: "Personas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_areas_AreaPacienteAreaId",
                table: "Personas",
                column: "AreaPacienteAreaId",
                principalTable: "areas",
                principalColumn: "AreaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistorialMedico_Personas_PacienteId",
                table: "HistorialMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Usuarios_UsuarioId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_areas_AreaPacienteAreaId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "IngresoPacientes");

            migrationBuilder.DropTable(
                name: "lLamadas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "areas");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Personas_AreaPacienteAreaId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_UsuarioId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_HistorialMedico_PacienteId",
                table: "HistorialMedico");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "HistorialMedico");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Personas",
                newName: "PacienteId");

            migrationBuilder.RenameColumn(
                name: "AreaPacienteAreaId",
                table: "Personas",
                newName: "HistorialMedicoId");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistorialMedico",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_HistorialMedicoId",
                table: "Personas",
                column: "HistorialMedicoId",
                unique: true,
                filter: "[HistorialMedicoId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_HistorialMedico_HistorialMedicoId",
                table: "Personas",
                column: "HistorialMedicoId",
                principalTable: "HistorialMedico",
                principalColumn: "HistorialMedicoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

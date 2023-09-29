using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olimpiadas2023.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoTablaLLamada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Llamadas",
                columns: table => new
                {
                    LlamadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoLLamada = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    origenLlamado = table.Column<int>(type: "int", nullable: false),
                    Atendio = table.Column<bool>(type: "bit", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    PacienteAsignadoPersonaId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Llamadas", x => x.LlamadaId);
                    table.ForeignKey(
                        name: "FK_Llamadas_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Llamadas_Personas_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Llamadas_Personas_PacienteAsignadoPersonaId",
                        column: x => x.PacienteAsignadoPersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Llamadas_AreaId",
                table: "Llamadas",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Llamadas_EmpleadoId",
                table: "Llamadas",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Llamadas_PacienteAsignadoPersonaId",
                table: "Llamadas",
                column: "PacienteAsignadoPersonaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Llamadas");
        }
    }
}

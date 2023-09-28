using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olimpiadas2023.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoDescriminador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngresoPacientes_Habitaciones_HabitacionId",
                table: "IngresoPacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_IngresoPacientes_Personas_PacienteId",
                table: "IngresoPacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Usuarios_UsuarioId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_areas_AreaPacienteAreaId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Roles_RolId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "lLamadas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngresoPacientes",
                table: "IngresoPacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_areas",
                table: "areas");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Rol");

            migrationBuilder.RenameTable(
                name: "IngresoPacientes",
                newName: "IngresoPaciente");

            migrationBuilder.RenameTable(
                name: "areas",
                newName: "Area");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuario",
                newName: "IX_Usuario_RolId");

            migrationBuilder.RenameIndex(
                name: "IX_IngresoPacientes_PacienteId",
                table: "IngresoPaciente",
                newName: "IX_IngresoPaciente_PacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_IngresoPacientes_HabitacionId",
                table: "IngresoPaciente",
                newName: "IX_IngresoPaciente_HabitacionId");

            migrationBuilder.AlterColumn<int>(
                name: "Importancia",
                table: "IngresoPaciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "TipoArea",
                table: "Area",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rol",
                table: "Rol",
                column: "RolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngresoPaciente",
                table: "IngresoPaciente",
                column: "IngresoPacienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Area",
                table: "Area",
                column: "AreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngresoPaciente_Habitaciones_HabitacionId",
                table: "IngresoPaciente",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "HabitacionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngresoPaciente_Personas_PacienteId",
                table: "IngresoPaciente",
                column: "PacienteId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Area_AreaPacienteAreaId",
                table: "Personas",
                column: "AreaPacienteAreaId",
                principalTable: "Area",
                principalColumn: "AreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Usuario_UsuarioId",
                table: "Personas",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Rol_RolId",
                table: "Usuario",
                column: "RolId",
                principalTable: "Rol",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngresoPaciente_Habitaciones_HabitacionId",
                table: "IngresoPaciente");

            migrationBuilder.DropForeignKey(
                name: "FK_IngresoPaciente_Personas_PacienteId",
                table: "IngresoPaciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Area_AreaPacienteAreaId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Usuario_UsuarioId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Rol_RolId",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rol",
                table: "Rol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngresoPaciente",
                table: "IngresoPaciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Area",
                table: "Area");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Rol",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "IngresoPaciente",
                newName: "IngresoPacientes");

            migrationBuilder.RenameTable(
                name: "Area",
                newName: "areas");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_RolId",
                table: "Usuarios",
                newName: "IX_Usuarios_RolId");

            migrationBuilder.RenameIndex(
                name: "IX_IngresoPaciente_PacienteId",
                table: "IngresoPacientes",
                newName: "IX_IngresoPacientes_PacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_IngresoPaciente_HabitacionId",
                table: "IngresoPacientes",
                newName: "IX_IngresoPacientes_HabitacionId");

            migrationBuilder.AlterColumn<string>(
                name: "Importancia",
                table: "IngresoPacientes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TipoArea",
                table: "areas",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngresoPacientes",
                table: "IngresoPacientes",
                column: "IngresoPacienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_areas",
                table: "areas",
                column: "AreaId");

            migrationBuilder.CreateTable(
                name: "lLamadas",
                columns: table => new
                {
                    LlamadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    PacienteAsignadoPersonaId = table.Column<int>(type: "int", nullable: true),
                    Atendio = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    origenLlamado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tipoLLamada = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
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

            migrationBuilder.AddForeignKey(
                name: "FK_IngresoPacientes_Habitaciones_HabitacionId",
                table: "IngresoPacientes",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "HabitacionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngresoPacientes_Personas_PacienteId",
                table: "IngresoPacientes",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Roles_RolId",
                table: "Usuarios",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

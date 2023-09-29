using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olimpiadas2023.Migrations
{
    /// <inheritdoc />
    public partial class CambioNombreHabitacionString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Habitaciones_NumeroHabitacion",
                table: "Habitaciones");

            migrationBuilder.DropColumn(
                name: "NumeroHabitacion",
                table: "Habitaciones");

            migrationBuilder.AddColumn<string>(
                name: "NombreHabitacion",
                table: "Habitaciones",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_NombreHabitacion",
                table: "Habitaciones",
                column: "NombreHabitacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Habitaciones_NombreHabitacion",
                table: "Habitaciones");

            migrationBuilder.DropColumn(
                name: "NombreHabitacion",
                table: "Habitaciones");

            migrationBuilder.AddColumn<int>(
                name: "NumeroHabitacion",
                table: "Habitaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_NumeroHabitacion",
                table: "Habitaciones",
                column: "NumeroHabitacion");
        }
    }
}

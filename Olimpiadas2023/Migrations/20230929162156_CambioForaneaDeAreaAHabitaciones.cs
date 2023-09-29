using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olimpiadas2023.Migrations
{
    /// <inheritdoc />
    public partial class CambioForaneaDeAreaAHabitaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Llamadas_Areas_AreaId",
                table: "Llamadas");

            migrationBuilder.RenameColumn(
                name: "AreaId",
                table: "Llamadas",
                newName: "HabitacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Llamadas_AreaId",
                table: "Llamadas",
                newName: "IX_Llamadas_HabitacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Llamadas_Habitaciones_HabitacionId",
                table: "Llamadas",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "HabitacionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Llamadas_Habitaciones_HabitacionId",
                table: "Llamadas");

            migrationBuilder.RenameColumn(
                name: "HabitacionId",
                table: "Llamadas",
                newName: "AreaId");

            migrationBuilder.RenameIndex(
                name: "IX_Llamadas_HabitacionId",
                table: "Llamadas",
                newName: "IX_Llamadas_AreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Llamadas_Areas_AreaId",
                table: "Llamadas",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "AreaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

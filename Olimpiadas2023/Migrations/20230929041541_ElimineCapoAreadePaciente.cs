using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olimpiadas2023.Migrations
{
    /// <inheritdoc />
    public partial class ElimineCapoAreadePaciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Area_AreaPacienteAreaId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropIndex(
                name: "IX_Personas_AreaPacienteAreaId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "AreaPacienteAreaId",
                table: "Personas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaPacienteAreaId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoAcceso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoArea = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.AreaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_AreaPacienteAreaId",
                table: "Personas",
                column: "AreaPacienteAreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Area_AreaPacienteAreaId",
                table: "Personas",
                column: "AreaPacienteAreaId",
                principalTable: "Area",
                principalColumn: "AreaId");
        }
    }
}

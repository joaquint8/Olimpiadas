using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olimpiadas2023.Migrations
{
    /// <inheritdoc />
    public partial class TablaAreaBienHecha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "Habitaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoArea = table.Column<int>(type: "int", nullable: false),
                    TipoAcceso = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_AreaId",
                table: "Habitaciones",
                column: "AreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitaciones_Areas_AreaId",
                table: "Habitaciones",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "AreaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitaciones_Areas_AreaId",
                table: "Habitaciones");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropIndex(
                name: "IX_Habitaciones_AreaId",
                table: "Habitaciones");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "Habitaciones");
        }
    }
}

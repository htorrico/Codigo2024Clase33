using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codigo2024Clase33.Migrations
{
    /// <inheritdoc />
    public partial class v6_llaveforanea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacturaID",
                table: "Detalles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_FacturaID",
                table: "Detalles",
                column: "FacturaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Facturas_FacturaID",
                table: "Detalles",
                column: "FacturaID",
                principalTable: "Facturas",
                principalColumn: "FacturaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Facturas_FacturaID",
                table: "Detalles");

            migrationBuilder.DropIndex(
                name: "IX_Detalles_FacturaID",
                table: "Detalles");

            migrationBuilder.DropColumn(
                name: "FacturaID",
                table: "Detalles");
        }
    }
}

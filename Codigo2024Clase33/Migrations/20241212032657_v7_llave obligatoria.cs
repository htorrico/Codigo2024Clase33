using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codigo2024Clase33.Migrations
{
    /// <inheritdoc />
    public partial class v7_llaveobligatoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Facturas_FacturaID",
                table: "Detalles");

            migrationBuilder.AlterColumn<int>(
                name: "FacturaID",
                table: "Detalles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Facturas_FacturaID",
                table: "Detalles",
                column: "FacturaID",
                principalTable: "Facturas",
                principalColumn: "FacturaID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Facturas_FacturaID",
                table: "Detalles");

            migrationBuilder.AlterColumn<int>(
                name: "FacturaID",
                table: "Detalles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Facturas_FacturaID",
                table: "Detalles",
                column: "FacturaID",
                principalTable: "Facturas",
                principalColumn: "FacturaID");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DYASProject.Migrations
{
    /// <inheritdoc />
    public partial class DecimalIncremented : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Ventas",
                type: "Decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "ProductoMotos",
                type: "decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "DetallesVentas",
                type: "Decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "DetallesVentas",
                type: "Decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(6,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Ventas",
                type: "Decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(8,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "ProductoMotos",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "DetallesVentas",
                type: "Decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(8,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "DetallesVentas",
                type: "Decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(8,2)");
        }
    }
}

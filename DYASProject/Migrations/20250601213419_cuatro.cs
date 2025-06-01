using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DYASProject.Migrations
{
    /// <inheritdoc />
    public partial class cuatro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Roles_RolId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_StockSucursales_ProductoMotos_IdMoto",
                table: "StockSucursales");

            migrationBuilder.DropIndex(
                name: "IX_StockSucursales_IdMoto",
                table: "StockSucursales");

            migrationBuilder.DropColumn(
                name: "IdMoto",
                table: "StockSucursales");

            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "Empleados",
                newName: "IdRol");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_RolId",
                table: "Empleados",
                newName: "IX_Empleados_IdRol");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Roles_IdRol",
                table: "Empleados",
                column: "IdRol",
                principalTable: "Roles",
                principalColumn: "IdRol",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockSucursales_ProductoMotos_ProductoMotoId",
                table: "StockSucursales",
                column: "ProductoMotoId",
                principalTable: "ProductoMotos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Roles_IdRol",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_StockSucursales_ProductoMotos_ProductoMotoId",
                table: "StockSucursales");

            migrationBuilder.RenameColumn(
                name: "IdRol",
                table: "Empleados",
                newName: "RolId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_IdRol",
                table: "Empleados",
                newName: "IX_Empleados_RolId");

            migrationBuilder.AddColumn<int>(
                name: "IdMoto",
                table: "StockSucursales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StockSucursales_IdMoto",
                table: "StockSucursales",
                column: "IdMoto");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Roles_RolId",
                table: "Empleados",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "IdRol",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockSucursales_ProductoMotos_IdMoto",
                table: "StockSucursales",
                column: "IdMoto",
                principalTable: "ProductoMotos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

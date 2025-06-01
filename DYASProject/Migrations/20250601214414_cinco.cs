using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DYASProject.Migrations
{
    /// <inheritdoc />
    public partial class cinco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVentas_ProductoMotos_IdMoto",
                table: "DetallesVentas");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVentas_Ventas_IdCompra",
                table: "DetallesVentas");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Roles_IdRol",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoMotos_Proveedores_IdProveedor",
                table: "ProductoMotos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Clientes_IdCliente",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Empleados_IdEmpleado",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_MetodosPago_IdMetodoPago",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "IdMetodoPago",
                table: "Ventas",
                newName: "MetodoPagoId");

            migrationBuilder.RenameColumn(
                name: "IdEmpleado",
                table: "Ventas",
                newName: "EmpleadoId");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Ventas",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_IdMetodoPago",
                table: "Ventas",
                newName: "IX_Ventas_MetodoPagoId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_IdEmpleado",
                table: "Ventas",
                newName: "IX_Ventas_EmpleadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_IdCliente",
                table: "Ventas",
                newName: "IX_Ventas_ClienteId");

            migrationBuilder.RenameColumn(
                name: "IdProveedor",
                table: "ProductoMotos",
                newName: "ProveedorId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoMotos_IdProveedor",
                table: "ProductoMotos",
                newName: "IX_ProductoMotos_ProveedorId");

            migrationBuilder.RenameColumn(
                name: "IdRol",
                table: "Empleados",
                newName: "RolId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_IdRol",
                table: "Empleados",
                newName: "IX_Empleados_RolId");

            migrationBuilder.RenameColumn(
                name: "IdMoto",
                table: "DetallesVentas",
                newName: "ProductoMotoID");

            migrationBuilder.RenameColumn(
                name: "IdCompra",
                table: "DetallesVentas",
                newName: "CompraId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesVentas_IdMoto",
                table: "DetallesVentas",
                newName: "IX_DetallesVentas_ProductoMotoID");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesVentas_IdCompra",
                table: "DetallesVentas",
                newName: "IX_DetallesVentas_CompraId");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Clientes",
                newName: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVentas_ProductoMotos_ProductoMotoID",
                table: "DetallesVentas",
                column: "ProductoMotoID",
                principalTable: "ProductoMotos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVentas_Ventas_CompraId",
                table: "DetallesVentas",
                column: "CompraId",
                principalTable: "Ventas",
                principalColumn: "IdVenta",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Roles_RolId",
                table: "Empleados",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "IdRol",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoMotos_Proveedores_ProveedorId",
                table: "ProductoMotos",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "IdProveedor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Clientes_ClienteId",
                table: "Ventas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Empleados_EmpleadoId",
                table: "Ventas",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_MetodosPago_MetodoPagoId",
                table: "Ventas",
                column: "MetodoPagoId",
                principalTable: "MetodosPago",
                principalColumn: "IdMetodo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVentas_ProductoMotos_ProductoMotoID",
                table: "DetallesVentas");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVentas_Ventas_CompraId",
                table: "DetallesVentas");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Roles_RolId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoMotos_Proveedores_ProveedorId",
                table: "ProductoMotos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Clientes_ClienteId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Empleados_EmpleadoId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_MetodosPago_MetodoPagoId",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "MetodoPagoId",
                table: "Ventas",
                newName: "IdMetodoPago");

            migrationBuilder.RenameColumn(
                name: "EmpleadoId",
                table: "Ventas",
                newName: "IdEmpleado");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Ventas",
                newName: "IdCliente");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_MetodoPagoId",
                table: "Ventas",
                newName: "IX_Ventas_IdMetodoPago");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_EmpleadoId",
                table: "Ventas",
                newName: "IX_Ventas_IdEmpleado");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas",
                newName: "IX_Ventas_IdCliente");

            migrationBuilder.RenameColumn(
                name: "ProveedorId",
                table: "ProductoMotos",
                newName: "IdProveedor");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoMotos_ProveedorId",
                table: "ProductoMotos",
                newName: "IX_ProductoMotos_IdProveedor");

            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "Empleados",
                newName: "IdRol");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_RolId",
                table: "Empleados",
                newName: "IX_Empleados_IdRol");

            migrationBuilder.RenameColumn(
                name: "ProductoMotoID",
                table: "DetallesVentas",
                newName: "IdMoto");

            migrationBuilder.RenameColumn(
                name: "CompraId",
                table: "DetallesVentas",
                newName: "IdCompra");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesVentas_ProductoMotoID",
                table: "DetallesVentas",
                newName: "IX_DetallesVentas_IdMoto");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesVentas_CompraId",
                table: "DetallesVentas",
                newName: "IX_DetallesVentas_IdCompra");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Clientes",
                newName: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVentas_ProductoMotos_IdMoto",
                table: "DetallesVentas",
                column: "IdMoto",
                principalTable: "ProductoMotos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVentas_Ventas_IdCompra",
                table: "DetallesVentas",
                column: "IdCompra",
                principalTable: "Ventas",
                principalColumn: "IdVenta",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Roles_IdRol",
                table: "Empleados",
                column: "IdRol",
                principalTable: "Roles",
                principalColumn: "IdRol",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoMotos_Proveedores_IdProveedor",
                table: "ProductoMotos",
                column: "IdProveedor",
                principalTable: "Proveedores",
                principalColumn: "IdProveedor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Clientes_IdCliente",
                table: "Ventas",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Empleados_IdEmpleado",
                table: "Ventas",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_MetodosPago_IdMetodoPago",
                table: "Ventas",
                column: "IdMetodoPago",
                principalTable: "MetodosPago",
                principalColumn: "IdMetodo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

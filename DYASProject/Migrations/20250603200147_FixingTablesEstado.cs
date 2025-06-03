using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DYASProject.Migrations
{
    /// <inheritdoc />
    public partial class FixingTablesEstado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpcionesDevolucione_EstadoDevolucion_EstadoDevolucionIdEstadoD",
                table: "OpcionesDevolucione");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcionesDevolucione_Ventas_VentaId",
                table: "OpcionesDevolucione");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoMotos_EstadoProductoMoto_EstadoProductoMotoIdEstadoPM",
                table: "ProductoMotos");

            migrationBuilder.DropIndex(
                name: "IX_ProductoMotos_EstadoProductoMotoIdEstadoPM",
                table: "ProductoMotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpcionesDevolucione",
                table: "OpcionesDevolucione");

            migrationBuilder.DropIndex(
                name: "IX_OpcionesDevolucione_EstadoDevolucionIdEstadoD",
                table: "OpcionesDevolucione");

            migrationBuilder.DropColumn(
                name: "EstadoProductoMotoIdEstadoPM",
                table: "ProductoMotos");

            migrationBuilder.DropColumn(
                name: "EstadoDevolucionIdEstadoD",
                table: "OpcionesDevolucione");

            migrationBuilder.RenameTable(
                name: "OpcionesDevolucione",
                newName: "OpcionesDevolucion");

            migrationBuilder.RenameIndex(
                name: "IX_OpcionesDevolucione_VentaId",
                table: "OpcionesDevolucion",
                newName: "IX_OpcionesDevolucion_VentaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpcionesDevolucion",
                table: "OpcionesDevolucion",
                column: "IdDevolucion");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoMotos_EstadoPMId",
                table: "ProductoMotos",
                column: "EstadoPMId");

            migrationBuilder.CreateIndex(
                name: "IX_OpcionesDevolucion_EstadoDId",
                table: "OpcionesDevolucion",
                column: "EstadoDId");

            migrationBuilder.AddForeignKey(
                name: "FK_OpcionesDevolucion_EstadoDevolucion_EstadoDId",
                table: "OpcionesDevolucion",
                column: "EstadoDId",
                principalTable: "EstadoDevolucion",
                principalColumn: "IdEstadoD",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpcionesDevolucion_Ventas_VentaId",
                table: "OpcionesDevolucion",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "IdVenta",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoMotos_EstadoProductoMoto_EstadoPMId",
                table: "ProductoMotos",
                column: "EstadoPMId",
                principalTable: "EstadoProductoMoto",
                principalColumn: "IdEstadoPM",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpcionesDevolucion_EstadoDevolucion_EstadoDId",
                table: "OpcionesDevolucion");

            migrationBuilder.DropForeignKey(
                name: "FK_OpcionesDevolucion_Ventas_VentaId",
                table: "OpcionesDevolucion");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoMotos_EstadoProductoMoto_EstadoPMId",
                table: "ProductoMotos");

            migrationBuilder.DropIndex(
                name: "IX_ProductoMotos_EstadoPMId",
                table: "ProductoMotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpcionesDevolucion",
                table: "OpcionesDevolucion");

            migrationBuilder.DropIndex(
                name: "IX_OpcionesDevolucion_EstadoDId",
                table: "OpcionesDevolucion");

            migrationBuilder.RenameTable(
                name: "OpcionesDevolucion",
                newName: "OpcionesDevolucione");

            migrationBuilder.RenameIndex(
                name: "IX_OpcionesDevolucion_VentaId",
                table: "OpcionesDevolucione",
                newName: "IX_OpcionesDevolucione_VentaId");

            migrationBuilder.AddColumn<int>(
                name: "EstadoProductoMotoIdEstadoPM",
                table: "ProductoMotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstadoDevolucionIdEstadoD",
                table: "OpcionesDevolucione",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpcionesDevolucione",
                table: "OpcionesDevolucione",
                column: "IdDevolucion");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoMotos_EstadoProductoMotoIdEstadoPM",
                table: "ProductoMotos",
                column: "EstadoProductoMotoIdEstadoPM");

            migrationBuilder.CreateIndex(
                name: "IX_OpcionesDevolucione_EstadoDevolucionIdEstadoD",
                table: "OpcionesDevolucione",
                column: "EstadoDevolucionIdEstadoD");

            migrationBuilder.AddForeignKey(
                name: "FK_OpcionesDevolucione_EstadoDevolucion_EstadoDevolucionIdEstadoD",
                table: "OpcionesDevolucione",
                column: "EstadoDevolucionIdEstadoD",
                principalTable: "EstadoDevolucion",
                principalColumn: "IdEstadoD",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpcionesDevolucione_Ventas_VentaId",
                table: "OpcionesDevolucione",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "IdVenta",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoMotos_EstadoProductoMoto_EstadoProductoMotoIdEstadoPM",
                table: "ProductoMotos",
                column: "EstadoProductoMotoIdEstadoPM",
                principalTable: "EstadoProductoMoto",
                principalColumn: "IdEstadoPM",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

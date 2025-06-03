using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DYASProject.Migrations
{
    /// <inheritdoc />
    public partial class FixedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpcionesDevolucion_EstadoDevolucion_EstadoDId",
                table: "OpcionesDevolucion");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoMotos_EstadoProductoMoto_EstadoPMId",
                table: "ProductoMotos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoMotos_Estados_EstadoIdEstado",
                table: "ProductoMotos");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropIndex(
                name: "IX_ProductoMotos_EstadoIdEstado",
                table: "ProductoMotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoProductoMoto",
                table: "EstadoProductoMoto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoDevolucion",
                table: "EstadoDevolucion");

            migrationBuilder.DropColumn(
                name: "EstadoIdEstado",
                table: "ProductoMotos");

            migrationBuilder.RenameTable(
                name: "EstadoProductoMoto",
                newName: "EstadosProductoMotos");

            migrationBuilder.RenameTable(
                name: "EstadoDevolucion",
                newName: "EstadosDevolucion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosProductoMotos",
                table: "EstadosProductoMotos",
                column: "IdEstadoPM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosDevolucion",
                table: "EstadosDevolucion",
                column: "IdEstadoD");

            migrationBuilder.AddForeignKey(
                name: "FK_OpcionesDevolucion_EstadosDevolucion_EstadoDId",
                table: "OpcionesDevolucion",
                column: "EstadoDId",
                principalTable: "EstadosDevolucion",
                principalColumn: "IdEstadoD",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoMotos_EstadosProductoMotos_EstadoPMId",
                table: "ProductoMotos",
                column: "EstadoPMId",
                principalTable: "EstadosProductoMotos",
                principalColumn: "IdEstadoPM",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpcionesDevolucion_EstadosDevolucion_EstadoDId",
                table: "OpcionesDevolucion");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoMotos_EstadosProductoMotos_EstadoPMId",
                table: "ProductoMotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosProductoMotos",
                table: "EstadosProductoMotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosDevolucion",
                table: "EstadosDevolucion");

            migrationBuilder.RenameTable(
                name: "EstadosProductoMotos",
                newName: "EstadoProductoMoto");

            migrationBuilder.RenameTable(
                name: "EstadosDevolucion",
                newName: "EstadoDevolucion");

            migrationBuilder.AddColumn<int>(
                name: "EstadoIdEstado",
                table: "ProductoMotos",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoProductoMoto",
                table: "EstadoProductoMoto",
                column: "IdEstadoPM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoDevolucion",
                table: "EstadoDevolucion",
                column: "IdEstadoD");

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.IdEstado);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoMotos_EstadoIdEstado",
                table: "ProductoMotos",
                column: "EstadoIdEstado");

            migrationBuilder.AddForeignKey(
                name: "FK_OpcionesDevolucion_EstadoDevolucion_EstadoDId",
                table: "OpcionesDevolucion",
                column: "EstadoDId",
                principalTable: "EstadoDevolucion",
                principalColumn: "IdEstadoD",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoMotos_EstadoProductoMoto_EstadoPMId",
                table: "ProductoMotos",
                column: "EstadoPMId",
                principalTable: "EstadoProductoMoto",
                principalColumn: "IdEstadoPM",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoMotos_Estados_EstadoIdEstado",
                table: "ProductoMotos",
                column: "EstadoIdEstado",
                principalTable: "Estados",
                principalColumn: "IdEstado");
        }
    }
}

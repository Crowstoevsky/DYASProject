using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DYASProject.Migrations
{
    /// <inheritdoc />
    public partial class AddingTwoTablesEstado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoMotos_Estados_EstadoId",
                table: "ProductoMotos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "OpcionesDevolucione");

            migrationBuilder.RenameColumn(
                name: "EstadoId",
                table: "ProductoMotos",
                newName: "EstadoProductoMotoIdEstadoPM");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoMotos_EstadoId",
                table: "ProductoMotos",
                newName: "IX_ProductoMotos_EstadoProductoMotoIdEstadoPM");

            migrationBuilder.AddColumn<int>(
                name: "EstadoIdEstado",
                table: "ProductoMotos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoPMId",
                table: "ProductoMotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstadoDId",
                table: "OpcionesDevolucione",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstadoDevolucionIdEstadoD",
                table: "OpcionesDevolucione",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EstadoDevolucion",
                columns: table => new
                {
                    IdEstadoD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoDevolucion", x => x.IdEstadoD);
                });

            migrationBuilder.CreateTable(
                name: "EstadoProductoMoto",
                columns: table => new
                {
                    IdEstadoPM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoProductoMoto", x => x.IdEstadoPM);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoMotos_EstadoIdEstado",
                table: "ProductoMotos",
                column: "EstadoIdEstado");

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
                name: "FK_ProductoMotos_EstadoProductoMoto_EstadoProductoMotoIdEstadoPM",
                table: "ProductoMotos",
                column: "EstadoProductoMotoIdEstadoPM",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpcionesDevolucione_EstadoDevolucion_EstadoDevolucionIdEstadoD",
                table: "OpcionesDevolucione");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoMotos_EstadoProductoMoto_EstadoProductoMotoIdEstadoPM",
                table: "ProductoMotos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoMotos_Estados_EstadoIdEstado",
                table: "ProductoMotos");

            migrationBuilder.DropTable(
                name: "EstadoDevolucion");

            migrationBuilder.DropTable(
                name: "EstadoProductoMoto");

            migrationBuilder.DropIndex(
                name: "IX_ProductoMotos_EstadoIdEstado",
                table: "ProductoMotos");

            migrationBuilder.DropIndex(
                name: "IX_OpcionesDevolucione_EstadoDevolucionIdEstadoD",
                table: "OpcionesDevolucione");

            migrationBuilder.DropColumn(
                name: "EstadoIdEstado",
                table: "ProductoMotos");

            migrationBuilder.DropColumn(
                name: "EstadoPMId",
                table: "ProductoMotos");

            migrationBuilder.DropColumn(
                name: "EstadoDId",
                table: "OpcionesDevolucione");

            migrationBuilder.DropColumn(
                name: "EstadoDevolucionIdEstadoD",
                table: "OpcionesDevolucione");

            migrationBuilder.RenameColumn(
                name: "EstadoProductoMotoIdEstadoPM",
                table: "ProductoMotos",
                newName: "EstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoMotos_EstadoProductoMotoIdEstadoPM",
                table: "ProductoMotos",
                newName: "IX_ProductoMotos_EstadoId");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "OpcionesDevolucione",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoMotos_Estados_EstadoId",
                table: "ProductoMotos",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "IdEstado",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

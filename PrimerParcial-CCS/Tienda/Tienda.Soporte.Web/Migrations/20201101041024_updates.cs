using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tienda.Soporte.Web.Migrations
{
    public partial class updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleServicios_Productos_ProductoId",
                table: "DetalleServicios");

            migrationBuilder.DropPrimaryKey(
                name: "detalleTrabajo",
                table: "FormTrabajos");

            migrationBuilder.DropIndex(
                name: "IX_DetalleServicios_ProductoId",
                table: "DetalleServicios");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "DetalleServicios");

            migrationBuilder.RenameColumn(
                name: "DetalleTrabajo",
                table: "FormTrabajos",
                newName: "detalleTrabajo");

            migrationBuilder.AlterColumn<string>(
                name: "detalleTrabajo",
                table: "FormTrabajos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "formTrabajoId",
                table: "FormTrabajos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OrdenProductos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DetalleServicioId = table.Column<Guid>(nullable: true),
                    ProductoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ordenProductoId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenProductos_DetalleServicios_DetalleServicioId",
                        column: x => x.DetalleServicioId,
                        principalTable: "DetalleServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenProductos_DetalleServicioId",
                table: "OrdenProductos",
                column: "DetalleServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenProductos_ProductoId",
                table: "OrdenProductos",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdenProductos");

            migrationBuilder.DropPrimaryKey(
                name: "formTrabajoId",
                table: "FormTrabajos");

            migrationBuilder.RenameColumn(
                name: "detalleTrabajo",
                table: "FormTrabajos",
                newName: "DetalleTrabajo");

            migrationBuilder.AlterColumn<string>(
                name: "DetalleTrabajo",
                table: "FormTrabajos",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductoId",
                table: "DetalleServicios",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "detalleTrabajo",
                table: "FormTrabajos",
                column: "DetalleTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleServicios_ProductoId",
                table: "DetalleServicios",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleServicios_Productos_ProductoId",
                table: "DetalleServicios",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

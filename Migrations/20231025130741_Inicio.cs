using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amy_Cherrez_Examen1P.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmyCherrez_TablaFactura",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmDescription_Producto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmPagoEfectivo = table.Column<bool>(type: "bit", nullable: false),
                    AmPrecio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmyCherrez_TablaFactura", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmyCherrez_TablaFactura");
        }
    }
}

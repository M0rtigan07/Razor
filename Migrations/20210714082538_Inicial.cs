using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Razor.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peli",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaEstreno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peli", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peli");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace SaturnoManagementAPI.Migrations
{
    public partial class Usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaturnoManagementAPI.Migrations
{
    public partial class Produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCompra",
                table: "Produtos");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoCompra",
                table: "Produtos",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Produtos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produtos");

            migrationBuilder.AlterColumn<double>(
                name: "PrecoCompra",
                table: "Produtos",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCompra",
                table: "Produtos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

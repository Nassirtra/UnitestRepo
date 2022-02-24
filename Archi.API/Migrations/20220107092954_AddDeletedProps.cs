using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Archi.API.Migrations
{
    public partial class AddDeletedProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Pizzas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Customers");
        }
    }
}

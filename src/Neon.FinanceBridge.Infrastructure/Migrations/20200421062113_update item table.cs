using Microsoft.EntityFrameworkCore.Migrations;

namespace Neon.FinanceBridge.Infrastructure.Migrations
{
    public partial class updateitemtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinimumQuantity",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "AlertQuantity",
                table: "Items",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlertQuantity",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "MinimumQuantity",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

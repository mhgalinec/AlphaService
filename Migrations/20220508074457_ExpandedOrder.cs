using Microsoft.EntityFrameworkCore.Migrations;

namespace AlphaService.Migrations
{
    public partial class ExpandedOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AirFilterChange",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BrakeFluidChange",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ChainChange",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OilChange",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirFilterChange",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BrakeFluidChange",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ChainChange",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OilChange",
                table: "Orders");
        }
    }
}

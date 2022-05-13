using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlphaService.Migrations
{
    public partial class Registration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrderRelationships",
                keyColumn: "UserOrderRelationshipId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserOrderRelationships",
                keyColumn: "UserOrderRelationshipId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserOrderRelationships",
                keyColumn: "UserOrderRelationshipId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Bikes",
                keyColumn: "BikeId",
                keyValue: 34,
                column: "BrakeFluidPrice",
                value: 20.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Bikes",
                keyColumn: "BikeId",
                keyValue: 34,
                column: "BrakeFluidPrice",
                value: 220.0);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Mileage", "Model", "Progress", "ServiceDate" },
                values: new object[,]
                {
                    { 1, 1200, "Kawasaki", "Active", new DateTime(2022, 5, 6, 17, 18, 13, 266, DateTimeKind.Local).AddTicks(6091) },
                    { 2, 1700, "Suzuki", "Active", new DateTime(2022, 5, 6, 17, 18, 13, 278, DateTimeKind.Local).AddTicks(7205) },
                    { 3, 3200, "Kawasaki", "Canceled", new DateTime(2022, 5, 6, 17, 18, 13, 278, DateTimeKind.Local).AddTicks(7259) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email" },
                values: new object[,]
                {
                    { 1, "test@kodius.com" },
                    { 2, "test@test.com" }
                });

            migrationBuilder.InsertData(
                table: "UserOrderRelationships",
                columns: new[] { "UserOrderRelationshipId", "OrderId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "UserOrderRelationships",
                columns: new[] { "UserOrderRelationshipId", "OrderId", "UserId" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "UserOrderRelationships",
                columns: new[] { "UserOrderRelationshipId", "OrderId", "UserId" },
                values: new object[] { 3, 3, 1 });
        }
    }
}

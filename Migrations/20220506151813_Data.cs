using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlphaService.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LastSupportedYear",
                table: "BikeModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 1,
                column: "LastSupportedYear",
                value: 1994);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 2,
                column: "LastSupportedYear",
                value: 1995);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 3,
                column: "LastSupportedYear",
                value: 1991);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 4,
                column: "LastSupportedYear",
                value: 1996);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 5,
                column: "LastSupportedYear",
                value: 1992);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 6,
                column: "LastSupportedYear",
                value: 1995);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 7,
                column: "LastSupportedYear",
                value: 1994);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 8,
                column: "LastSupportedYear",
                value: 1996);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 9,
                column: "LastSupportedYear",
                value: 1991);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 10,
                column: "LastSupportedYear",
                value: 1991);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 11,
                column: "LastSupportedYear",
                value: 1991);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 12,
                column: "LastSupportedYear",
                value: 1991);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 13,
                column: "LastSupportedYear",
                value: 1991);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 14,
                column: "LastSupportedYear",
                value: 1996);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 15,
                column: "LastSupportedYear",
                value: 1995);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 16,
                column: "LastSupportedYear",
                value: 1991);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 17,
                column: "LastSupportedYear",
                value: 1994);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 18,
                column: "LastSupportedYear",
                value: 1993);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 19,
                column: "LastSupportedYear",
                value: 1995);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 20,
                column: "LastSupportedYear",
                value: 1991);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 21,
                column: "LastSupportedYear",
                value: 1991);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 22,
                column: "LastSupportedYear",
                value: 1995);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 23,
                column: "LastSupportedYear",
                value: 1992);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 24,
                column: "LastSupportedYear",
                value: 1991);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 25,
                column: "LastSupportedYear",
                value: 1993);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 26,
                column: "LastSupportedYear",
                value: 1993);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 27,
                column: "LastSupportedYear",
                value: 1995);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 28,
                column: "LastSupportedYear",
                value: 1994);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 29,
                column: "LastSupportedYear",
                value: 1992);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 30,
                column: "LastSupportedYear",
                value: 1992);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 31,
                column: "LastSupportedYear",
                value: 1992);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 32,
                column: "LastSupportedYear",
                value: 1994);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 33,
                column: "LastSupportedYear",
                value: 1996);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 34,
                column: "LastSupportedYear",
                value: 1995);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 35,
                column: "LastSupportedYear",
                value: 1995);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 36,
                column: "LastSupportedYear",
                value: 1995);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 37,
                column: "LastSupportedYear",
                value: 1993);

            migrationBuilder.UpdateData(
                table: "BikeModels",
                keyColumn: "BikeModelId",
                keyValue: 38,
                column: "LastSupportedYear",
                value: 1993);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "ServiceDate",
                value: new DateTime(2022, 5, 6, 17, 18, 13, 266, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "ServiceDate",
                value: new DateTime(2022, 5, 6, 17, 18, 13, 278, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "ServiceDate",
                value: new DateTime(2022, 5, 6, 17, 18, 13, 278, DateTimeKind.Local).AddTicks(7259));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastSupportedYear",
                table: "BikeModels");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "ServiceDate",
                value: new DateTime(2022, 5, 5, 17, 0, 32, 506, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "ServiceDate",
                value: new DateTime(2022, 5, 5, 17, 0, 32, 517, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "ServiceDate",
                value: new DateTime(2022, 5, 5, 17, 0, 32, 517, DateTimeKind.Local).AddTicks(7623));
        }
    }
}

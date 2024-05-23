using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelMapTurkey.Data.Migrations
{
    /// <inheritdoc />
    public partial class ForUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4059af06-7ca5-46f5-a7b5-5e1154c4d510", "AQAAAAIAAYagAAAAEJlTdhwrkF+0iX66rbIKSL9HTlSaiPRyY4Ej6CiOSaab2tt0bQUe69MWfWEH6AL83A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3adde86a-58b4-4630-9fe9-585b0ff4ba62", "AQAAAAIAAYagAAAAEM3hgCVODw+XqfPxddvtBBVklsqzSlp8z/uEt+RSg8q4+lQtrwE+N/Ez8cXOb/kOXA==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 14, 2, 26, 98, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 14, 2, 26, 98, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 14, 2, 26, 98, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 14, 2, 26, 98, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 14, 2, 26, 98, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 14, 2, 26, 98, DateTimeKind.Local).AddTicks(6270));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75f9446e-e133-4cea-bc54-e24708845dfc", "AQAAAAIAAYagAAAAEJS2v/edOIZ4zHt9Zg6rhTs5lXiVcQ1oxHEnXVFb+PJqR8zlUDZMDuKxnlABDQI0QQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b61020af-2f0b-4f93-abec-1798da09b097", "AQAAAAIAAYagAAAAEDtRsWL0IMC+Ub+EZ0CeRANY6oxwPPQPHqBqZGKHUlLf4GATuTE9FdX863L4rlKjrg==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 11, 54, 24, 186, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 11, 54, 24, 186, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 11, 54, 24, 186, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 11, 54, 24, 186, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 11, 54, 24, 186, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 23, 11, 54, 24, 186, DateTimeKind.Local).AddTicks(5909));
        }
    }
}

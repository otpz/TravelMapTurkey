using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelMapTurkey.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08170431-bcf6-4239-acbe-5298fef072c9", "AQAAAAIAAYagAAAAEE+9KIYVCnFF3j/Aydtx1mYuURIzKsWpNMXlhwvxdJr81uonemiz/NGWOWloiFMlzQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "05a1fde7-31b7-4d69-afa6-e575b43f2e3c", "AQAAAAIAAYagAAAAEGrbnP2AeRiQ1Kau/eXzbEp9JdI8agwN6DVxl1ripkWccRdDRIc/xICfBNwaqbe74A==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 13, 21, 39, 565, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 13, 21, 39, 565, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 13, 21, 39, 566, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 13, 21, 39, 566, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 13, 21, 39, 566, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 13, 21, 39, 566, DateTimeKind.Local).AddTicks(1917));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5fc2a3d-2537-4cd9-b8d7-3d046e0a7281", "AQAAAAIAAYagAAAAEGIUiQDfs3BqxIPxfedVOXSXm9oR9cj+9lS/r58bvCWfkhnYq6epTMCrcFSyv8FGXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "059cc91c-9d4f-4d52-8882-7cf3242226ba", "AQAAAAIAAYagAAAAEMU/q+vt+maYYuiB2+afvkhWWi8aU4+BpiZrLnHaVRCIrircHWn2uDkRjN6gjdqR5Q==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 45, 46, 458, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 45, 46, 458, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 45, 46, 458, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 45, 46, 458, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 45, 46, 458, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 24, 11, 45, 46, 458, DateTimeKind.Local).AddTicks(5820));
        }
    }
}

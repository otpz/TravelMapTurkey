using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelMapTurkey.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}

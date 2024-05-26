using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelMapTurkey.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_AspNetUsers_UserId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_UserId",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e26a97fb-cfdb-4f15-84d1-a290bfffb8d8", "AQAAAAIAAYagAAAAEKhPLXAbhAbDnsA2CjYfKrPNakO6TYoWfVVSoFeSSauKkD5KpMZdcuk13RAbu+RSBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5519c9d7-8f79-4609-8a3b-c78c7a05a464", "AQAAAAIAAYagAAAAEOQZNJW5JigJY5EFKPavZO0mNxdeC42bJwXE3LMLaH4WUHx0rTXfTk/Gf0rzWMVo3A==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { null, new DateTime(2024, 5, 26, 16, 23, 20, 402, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppUserId", "CreatedDate" },
                values: new object[] { null, new DateTime(2024, 5, 26, 16, 23, 20, 402, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 16, 23, 20, 402, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 16, 23, 20, 402, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 16, 23, 20, 402, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 16, 23, 20, 402, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.CreateIndex(
                name: "IX_Cities_AppUserId",
                table: "Cities",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_AspNetUsers_AppUserId",
                table: "Cities",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_AspNetUsers_AppUserId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_AppUserId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Cities");

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

            migrationBuilder.CreateIndex(
                name: "IX_Cities_UserId",
                table: "Cities",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_AspNetUsers_UserId",
                table: "Cities",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

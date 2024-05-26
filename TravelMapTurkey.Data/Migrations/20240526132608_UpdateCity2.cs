using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelMapTurkey.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e23ef4bb-6676-405c-a1d7-eb4c20606e85", "AQAAAAIAAYagAAAAEAocqHWzTqD6HmRYA/F0T5YK97SbZdKdyCjgO/5WboNmveQ4C6i0P0RGxt0SXOejFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36529ceb-44f8-4df3-ad4a-bd39c18701f9", "AQAAAAIAAYagAAAAEMjBT4xog8EbJimT04E5s4Qqx55ZrkOxtL4McEytZ5cJqfNi9cgplNcZVIn3vIml1A==" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 16, 26, 8, 456, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 16, 26, 8, 456, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 16, 26, 8, 457, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "CityReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 16, 26, 8, 457, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 16, 26, 8, 457, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 26, 16, 26, 8, 457, DateTimeKind.Local).AddTicks(2328));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

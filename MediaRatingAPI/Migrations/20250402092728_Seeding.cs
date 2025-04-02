using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MediaRatingAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Format", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Film", 9, new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bookworm" },
                    { 2, "TV", 10, new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Invincible (Season 1)" },
                    { 3, "Film", 9, new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flow" },
                    { 4, "Film", 10, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hot Fuzz" },
                    { 5, "TV", 7, new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ar y Ffin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

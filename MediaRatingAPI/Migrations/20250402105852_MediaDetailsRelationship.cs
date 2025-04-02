using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediaRatingAPI.Migrations
{
    /// <inheritdoc />
    public partial class MediaDetailsRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Medias");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Medias");

            migrationBuilder.CreateTable(
                name: "MediaDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaDetails_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MediaDetails_MediaId",
                table: "MediaDetails",
                column: "MediaId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaDetails");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Medias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Medias",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 9, new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 10, new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 9, new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 10, new DateTime(2007, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Rating", "ReleaseDate" },
                values: new object[] { 7, new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}

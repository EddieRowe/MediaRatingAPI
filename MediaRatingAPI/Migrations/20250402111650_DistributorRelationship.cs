using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediaRatingAPI.Migrations
{
    /// <inheritdoc />
    public partial class DistributorRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "Medias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Distributors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributors", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DistributorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                column: "DistributorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3,
                column: "DistributorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4,
                column: "DistributorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5,
                column: "DistributorId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Medias_DistributorId",
                table: "Medias",
                column: "DistributorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Distributors_DistributorId",
                table: "Medias",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Distributors_DistributorId",
                table: "Medias");

            migrationBuilder.DropTable(
                name: "Distributors");

            migrationBuilder.DropIndex(
                name: "IX_Medias_DistributorId",
                table: "Medias");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "Medias");
        }
    }
}

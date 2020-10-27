using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCSamples.Migrations
{
    public partial class ThridVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "IMDB_Bewertung",
                table: "Movie",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMDB_Bewertung",
                table: "Movie");
        }
    }
}

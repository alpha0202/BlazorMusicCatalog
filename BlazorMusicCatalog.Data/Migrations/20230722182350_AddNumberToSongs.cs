using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorMusicCatalog.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNumberToSongs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Song",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Song");
        }
    }
}

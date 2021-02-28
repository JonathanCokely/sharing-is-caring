using Microsoft.EntityFrameworkCore.Migrations;

namespace SharingIsCaring.Migrations
{
    public partial class CorrectAssetsAvailableProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availabile",
                table: "Assets");

            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Assets",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "Assets");

            migrationBuilder.AddColumn<bool>(
                name: "Availabile",
                table: "Assets",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace SharingIsCaring.Migrations
{
    public partial class AssetReturnRequestedProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ReturnRequested",
                table: "Assets",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnRequested",
                table: "Assets");
        }
    }
}

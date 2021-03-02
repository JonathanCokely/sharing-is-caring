using Microsoft.EntityFrameworkCore.Migrations;

namespace SharingIsCaring.Migrations
{
    public partial class TransferRequestReturnRequestProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ReturnRequest",
                table: "TransferRequests",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnRequest",
                table: "TransferRequests");
        }
    }
}

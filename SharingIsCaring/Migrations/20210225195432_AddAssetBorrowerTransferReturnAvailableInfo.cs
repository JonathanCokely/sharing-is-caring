using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SharingIsCaring.Migrations
{
    public partial class AddAssetBorrowerTransferReturnAvailableInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Availabile",
                table: "Assets",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "BorrowerId",
                table: "Assets",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastReturnDate",
                table: "Assets",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastTransferDate",
                table: "Assets",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availabile",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "BorrowerId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "LastReturnDate",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "LastTransferDate",
                table: "Assets");
        }
    }
}

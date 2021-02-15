using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SharingIsCaring.Migrations
{
    public partial class BuildAssetRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeDescription",
                table: "AssetTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AssetRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AssetId = table.Column<int>(nullable: false),
                    OwnerId = table.Column<string>(nullable: true),
                    BorrowerId = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    ToDate = table.Column<DateTime>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetRequests", x => new { x.AssetId, x.Id });
                    table.ForeignKey(
                        name: "FK_AssetRequests_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetRequests");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TypeDescription",
                table: "AssetTypes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}

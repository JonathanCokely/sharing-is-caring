using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SharingIsCaring.Migrations
{
    public partial class BuildTransferRequestTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransferRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssetId = table.Column<int>(nullable: false),
                    ExpectedReturnDate = table.Column<DateTime>(nullable: false),
                    BorrowerId = table.Column<string>(nullable: true),
                    OwnerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferRequests_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetTransferRequests",
                columns: table => new
                {
                    AssetId = table.Column<int>(nullable: false),
                    TransferRequestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTransferRequests", x => new { x.AssetId, x.TransferRequestId });
                    table.ForeignKey(
                        name: "FK_AssetTransferRequests_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetTransferRequests_TransferRequests_TransferRequestId",
                        column: x => x.TransferRequestId,
                        principalTable: "TransferRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetTransferRequests_TransferRequestId",
                table: "AssetTransferRequests",
                column: "TransferRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferRequests_AssetId",
                table: "TransferRequests",
                column: "AssetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetTransferRequests");

            migrationBuilder.DropTable(
                name: "TransferRequests");
        }
    }
}

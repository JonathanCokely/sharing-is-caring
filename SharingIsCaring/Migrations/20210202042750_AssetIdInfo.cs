using Microsoft.EntityFrameworkCore.Migrations;

namespace SharingIsCaring.Migrations
{
    public partial class AssetIdInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Brands_BrandNameId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetTypes_ItemTypeId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_BrandNameId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "BorrowerId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "BrandNameId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Assets");

            migrationBuilder.AlterColumn<int>(
                name: "ItemTypeId",
                table: "Assets",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Assets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Assets_BrandId",
                table: "Assets",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Brands_BrandId",
                table: "Assets",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetTypes_ItemTypeId",
                table: "Assets",
                column: "ItemTypeId",
                principalTable: "AssetTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Brands_BrandId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetTypes_ItemTypeId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_BrandId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Assets");

            migrationBuilder.AlterColumn<int>(
                name: "ItemTypeId",
                table: "Assets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BorrowerId",
                table: "Assets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandNameId",
                table: "Assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Assets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Assets_BrandNameId",
                table: "Assets",
                column: "BrandNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Brands_BrandNameId",
                table: "Assets",
                column: "BrandNameId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetTypes_ItemTypeId",
                table: "Assets",
                column: "ItemTypeId",
                principalTable: "AssetTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class FiltrableStorage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilterCategoryId",
                table: "StorageBoxes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilterCategoryId",
                table: "StorageAreas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StorageBoxes_FilterCategoryId",
                table: "StorageBoxes",
                column: "FilterCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageAreas_FilterCategoryId",
                table: "StorageAreas",
                column: "FilterCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_StorageAreas_Categories_FilterCategoryId",
                table: "StorageAreas",
                column: "FilterCategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StorageBoxes_Categories_FilterCategoryId",
                table: "StorageBoxes",
                column: "FilterCategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StorageAreas_Categories_FilterCategoryId",
                table: "StorageAreas");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageBoxes_Categories_FilterCategoryId",
                table: "StorageBoxes");

            migrationBuilder.DropIndex(
                name: "IX_StorageBoxes_FilterCategoryId",
                table: "StorageBoxes");

            migrationBuilder.DropIndex(
                name: "IX_StorageAreas_FilterCategoryId",
                table: "StorageAreas");

            migrationBuilder.DropColumn(
                name: "FilterCategoryId",
                table: "StorageBoxes");

            migrationBuilder.DropColumn(
                name: "FilterCategoryId",
                table: "StorageAreas");
        }
    }
}

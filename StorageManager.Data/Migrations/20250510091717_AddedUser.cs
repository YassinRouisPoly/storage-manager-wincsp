using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_storage_boxes_storage_areas_AreaId",
                table: "storage_boxes");

            migrationBuilder.DropForeignKey(
                name: "FK_stored_products_products_ProductReferenceId",
                table: "stored_products");

            migrationBuilder.DropForeignKey(
                name: "FK_stored_products_storage_boxes_BoxId",
                table: "stored_products");

            migrationBuilder.DropForeignKey(
                name: "FK_transfers_products_LinkedProductReferenceId",
                table: "transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_transfers_storage_boxes_LinkedBoxId",
                table: "transfers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_transfers",
                table: "transfers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stored_products",
                table: "stored_products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_storage_boxes",
                table: "storage_boxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_storage_areas",
                table: "storage_areas");

            migrationBuilder.RenameTable(
                name: "transfers",
                newName: "Transfers");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "stored_products",
                newName: "StoredProducts");

            migrationBuilder.RenameTable(
                name: "storage_boxes",
                newName: "StorageBoxes");

            migrationBuilder.RenameTable(
                name: "storage_areas",
                newName: "StorageAreas");

            migrationBuilder.RenameIndex(
                name: "IX_transfers_LinkedProductReferenceId",
                table: "Transfers",
                newName: "IX_Transfers_LinkedProductReferenceId");

            migrationBuilder.RenameIndex(
                name: "IX_transfers_LinkedBoxId",
                table: "Transfers",
                newName: "IX_Transfers_LinkedBoxId");

            migrationBuilder.RenameIndex(
                name: "IX_products_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_stored_products_ProductReferenceId",
                table: "StoredProducts",
                newName: "IX_StoredProducts_ProductReferenceId");

            migrationBuilder.RenameIndex(
                name: "IX_stored_products_BoxId",
                table: "StoredProducts",
                newName: "IX_StoredProducts_BoxId");

            migrationBuilder.RenameIndex(
                name: "IX_storage_boxes_AreaId",
                table: "StorageBoxes",
                newName: "IX_StorageBoxes_AreaId");

            migrationBuilder.AddColumn<bool>(
                name: "IsFull",
                table: "StorageBoxes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transfers",
                table: "Transfers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoredProducts",
                table: "StoredProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorageBoxes",
                table: "StorageBoxes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorageAreas",
                table: "StorageAreas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StorageBoxes_StorageAreas_AreaId",
                table: "StorageBoxes",
                column: "AreaId",
                principalTable: "StorageAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoredProducts_Products_ProductReferenceId",
                table: "StoredProducts",
                column: "ProductReferenceId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoredProducts_StorageBoxes_BoxId",
                table: "StoredProducts",
                column: "BoxId",
                principalTable: "StorageBoxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Products_LinkedProductReferenceId",
                table: "Transfers",
                column: "LinkedProductReferenceId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_StorageBoxes_LinkedBoxId",
                table: "Transfers",
                column: "LinkedBoxId",
                principalTable: "StorageBoxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageBoxes_StorageAreas_AreaId",
                table: "StorageBoxes");

            migrationBuilder.DropForeignKey(
                name: "FK_StoredProducts_Products_ProductReferenceId",
                table: "StoredProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_StoredProducts_StorageBoxes_BoxId",
                table: "StoredProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Products_LinkedProductReferenceId",
                table: "Transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_StorageBoxes_LinkedBoxId",
                table: "Transfers");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transfers",
                table: "Transfers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoredProducts",
                table: "StoredProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorageBoxes",
                table: "StorageBoxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorageAreas",
                table: "StorageAreas");

            migrationBuilder.DropColumn(
                name: "IsFull",
                table: "StorageBoxes");

            migrationBuilder.RenameTable(
                name: "Transfers",
                newName: "transfers");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "products");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.RenameTable(
                name: "StoredProducts",
                newName: "stored_products");

            migrationBuilder.RenameTable(
                name: "StorageBoxes",
                newName: "storage_boxes");

            migrationBuilder.RenameTable(
                name: "StorageAreas",
                newName: "storage_areas");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_LinkedProductReferenceId",
                table: "transfers",
                newName: "IX_transfers_LinkedProductReferenceId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_LinkedBoxId",
                table: "transfers",
                newName: "IX_transfers_LinkedBoxId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "products",
                newName: "IX_products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_StoredProducts_ProductReferenceId",
                table: "stored_products",
                newName: "IX_stored_products_ProductReferenceId");

            migrationBuilder.RenameIndex(
                name: "IX_StoredProducts_BoxId",
                table: "stored_products",
                newName: "IX_stored_products_BoxId");

            migrationBuilder.RenameIndex(
                name: "IX_StorageBoxes_AreaId",
                table: "storage_boxes",
                newName: "IX_storage_boxes_AreaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_transfers",
                table: "transfers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stored_products",
                table: "stored_products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_storage_boxes",
                table: "storage_boxes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_storage_areas",
                table: "storage_areas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_storage_boxes_storage_areas_AreaId",
                table: "storage_boxes",
                column: "AreaId",
                principalTable: "storage_areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stored_products_products_ProductReferenceId",
                table: "stored_products",
                column: "ProductReferenceId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stored_products_storage_boxes_BoxId",
                table: "stored_products",
                column: "BoxId",
                principalTable: "storage_boxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transfers_products_LinkedProductReferenceId",
                table: "transfers",
                column: "LinkedProductReferenceId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transfers_storage_boxes_LinkedBoxId",
                table: "transfers",
                column: "LinkedBoxId",
                principalTable: "storage_boxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

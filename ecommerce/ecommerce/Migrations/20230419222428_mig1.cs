using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Variations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variations_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProductItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockQty = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "VariationOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VariationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariationOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VariationOptions_Variations_VariationId",
                        column: x => x.VariationId,
                        principalTable: "Variations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProductConfigurations",
                columns: table => new
                {
                    ProductItemId = table.Column<int>(type: "int", nullable: false),
                    VariationOptionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductConfigurations", x => new { x.ProductItemId, x.VariationOptionsId });
                    table.ForeignKey(
                        name: "FK_ProductConfigurations_ProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductConfigurations_VariationOptions_VariationOptionsId",
                        column: x => x.VariationOptionsId,
                        principalTable: "VariationOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tshirt" },
                    { 2, "Shoes" },
                    { 3, "Phone" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 1, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 2, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 3, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 4, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 5, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 6, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 7, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 8, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 9, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 10, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 11, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 12, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 13, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 14, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 15, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 16, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 17, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 18, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 19, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 20, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 21, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 22, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 23, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 24, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 25, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 26, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 27, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 28, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" },
                    { 29, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.png", "American Eagle" },
                    { 30, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.png", "Knight" }
                });

            migrationBuilder.InsertData(
                table: "Variations",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Color" },
                    { 2, 1, "Size" }
                });

            migrationBuilder.InsertData(
                table: "ProductItems",
                columns: new[] { "Id", "Image", "Price", "ProductId", "SKU", "StockQty" },
                values: new object[,]
                {
                    { 1, "/Image/Products/1.png", 120f, 1, "AmericanEagle-L-Red", 100 },
                    { 2, "/Image/Products/1.png", 100f, 1, "AmericanEagle-XL-Red", 50 },
                    { 3, "/Image/Products/1.png", 80f, 1, "AmericanEagle-L-Blue", 20 },
                    { 4, "/Image/Products/1.png", 200f, 1, "AmericanEagle-XL-Blue", 0 },
                    { 5, "/Image/Products/1.png", 120f, 2, "Knight-L-Red", 200 },
                    { 6, "/Image/Products/1.png", 100f, 2, "Knight-XL-Red", 300 },
                    { 7, "/Image/Products/1.png", 80f, 2, "Knight-L-Blue", 10 },
                    { 8, "/Image/Products/1.png", 200f, 2, "Knight-XL-Blue", 60 },
                    { 9, "/Image/Products/1.png", 120f, 3, "AmericanEagle-L-Red", 100 },
                    { 10, "/Image/Products/1.png", 100f, 3, "AmericanEagle-XL-Red", 50 },
                    { 11, "/Image/Products/1.png", 80f, 3, "AmericanEagle-L-Blue", 20 },
                    { 12, "/Image/Products/1.png", 200f, 3, "AmericanEagle-XL-Blue", 0 },
                    { 13, "/Image/Products/1.png", 120f, 4, "Knight-L-Red", 200 },
                    { 14, "/Image/Products/1.png", 100f, 4, "Knight-XL-Red", 300 },
                    { 15, "/Image/Products/1.png", 80f, 4, "Knight-L-Blue", 10 },
                    { 16, "/Image/Products/1.png", 200f, 4, "Knight-XL-Blue", 60 },
                    { 17, "/Image/Products/1.png", 120f, 5, "AmericanEagle-L-Red", 100 },
                    { 18, "/Image/Products/1.png", 100f, 5, "AmericanEagle-XL-Red", 50 },
                    { 19, "/Image/Products/1.png", 80f, 5, "AmericanEagle-L-Blue", 20 },
                    { 20, "/Image/Products/1.png", 200f, 5, "AmericanEagle-XL-Blue", 0 },
                    { 21, "/Image/Products/1.png", 120f, 6, "Knight-L-Red", 200 },
                    { 22, "/Image/Products/1.png", 100f, 6, "Knight-XL-Red", 300 },
                    { 23, "/Image/Products/1.png", 80f, 6, "Knight-L-Blue", 10 },
                    { 24, "/Image/Products/1.png", 200f, 6, "Knight-XL-Blue", 60 },
                    { 25, "/Image/Products/1.png", 120f, 7, "AmericanEagle-L-Red", 100 },
                    { 26, "/Image/Products/1.png", 100f, 7, "AmericanEagle-XL-Red", 50 },
                    { 27, "/Image/Products/1.png", 80f, 7, "AmericanEagle-L-Blue", 20 },
                    { 28, "/Image/Products/1.png", 200f, 7, "AmericanEagle-XL-Blue", 0 },
                    { 29, "/Image/Products/1.png", 120f, 8, "Knight-L-Red", 200 },
                    { 30, "/Image/Products/1.png", 100f, 8, "Knight-XL-Red", 300 },
                    { 31, "/Image/Products/1.png", 80f, 8, "Knight-L-Blue", 10 },
                    { 32, "/Image/Products/1.png", 200f, 8, "Knight-XL-Blue", 60 },
                    { 33, "/Image/Products/1.png", 120f, 9, "AmericanEagle-L-Red", 100 },
                    { 34, "/Image/Products/1.png", 100f, 9, "AmericanEagle-XL-Red", 50 },
                    { 35, "/Image/Products/1.png", 80f, 9, "AmericanEagle-L-Blue", 20 },
                    { 36, "/Image/Products/1.png", 200f, 9, "AmericanEagle-XL-Blue", 0 },
                    { 37, "/Image/Products/1.png", 120f, 10, "Knight-L-Red", 200 },
                    { 38, "/Image/Products/1.png", 100f, 10, "Knight-XL-Red", 300 },
                    { 39, "/Image/Products/1.png", 80f, 10, "Knight-L-Blue", 10 },
                    { 40, "/Image/Products/1.png", 200f, 10, "Knight-XL-Blue", 60 },
                    { 41, "/Image/Products/1.png", 120f, 11, "AmericanEagle-L-Red", 100 },
                    { 42, "/Image/Products/1.png", 100f, 11, "AmericanEagle-XL-Red", 50 },
                    { 43, "/Image/Products/1.png", 80f, 11, "AmericanEagle-L-Blue", 20 },
                    { 44, "/Image/Products/1.png", 200f, 11, "AmericanEagle-XL-Blue", 0 },
                    { 45, "/Image/Products/1.png", 120f, 12, "Knight-L-Red", 200 },
                    { 46, "/Image/Products/1.png", 100f, 12, "Knight-XL-Red", 300 },
                    { 47, "/Image/Products/1.png", 80f, 12, "Knight-L-Blue", 10 },
                    { 48, "/Image/Products/1.png", 200f, 12, "Knight-XL-Blue", 60 },
                    { 49, "/Image/Products/1.png", 120f, 13, "AmericanEagle-L-Red", 100 },
                    { 50, "/Image/Products/1.png", 100f, 13, "AmericanEagle-XL-Red", 50 },
                    { 51, "/Image/Products/1.png", 80f, 13, "AmericanEagle-L-Blue", 20 },
                    { 52, "/Image/Products/1.png", 200f, 13, "AmericanEagle-XL-Blue", 0 },
                    { 53, "/Image/Products/1.png", 120f, 14, "Knight-L-Red", 200 },
                    { 54, "/Image/Products/1.png", 100f, 14, "Knight-XL-Red", 300 },
                    { 55, "/Image/Products/1.png", 80f, 14, "Knight-L-Blue", 10 },
                    { 56, "/Image/Products/1.png", 200f, 14, "Knight-XL-Blue", 60 },
                    { 57, "/Image/Products/1.png", 120f, 15, "AmericanEagle-L-Red", 100 },
                    { 58, "/Image/Products/1.png", 100f, 15, "AmericanEagle-XL-Red", 50 },
                    { 59, "/Image/Products/1.png", 80f, 15, "AmericanEagle-L-Blue", 20 },
                    { 60, "/Image/Products/1.png", 200f, 15, "AmericanEagle-XL-Blue", 0 },
                    { 61, "/Image/Products/1.png", 120f, 16, "Knight-L-Red", 200 },
                    { 62, "/Image/Products/1.png", 100f, 16, "Knight-XL-Red", 300 },
                    { 63, "/Image/Products/1.png", 80f, 16, "Knight-L-Blue", 10 },
                    { 64, "/Image/Products/1.png", 200f, 16, "Knight-XL-Blue", 60 },
                    { 65, "/Image/Products/1.png", 120f, 17, "AmericanEagle-L-Red", 100 },
                    { 66, "/Image/Products/1.png", 100f, 17, "AmericanEagle-XL-Red", 50 },
                    { 67, "/Image/Products/1.png", 80f, 17, "AmericanEagle-L-Blue", 20 },
                    { 68, "/Image/Products/1.png", 200f, 17, "AmericanEagle-XL-Blue", 0 },
                    { 69, "/Image/Products/1.png", 120f, 18, "Knight-L-Red", 200 },
                    { 70, "/Image/Products/1.png", 100f, 18, "Knight-XL-Red", 300 },
                    { 71, "/Image/Products/1.png", 80f, 18, "Knight-L-Blue", 10 },
                    { 72, "/Image/Products/1.png", 200f, 18, "Knight-XL-Blue", 60 },
                    { 73, "/Image/Products/1.png", 120f, 19, "AmericanEagle-L-Red", 100 },
                    { 74, "/Image/Products/1.png", 100f, 19, "AmericanEagle-XL-Red", 50 },
                    { 75, "/Image/Products/1.png", 80f, 19, "AmericanEagle-L-Blue", 20 },
                    { 76, "/Image/Products/1.png", 200f, 19, "AmericanEagle-XL-Blue", 0 },
                    { 77, "/Image/Products/1.png", 120f, 20, "Knight-L-Red", 200 },
                    { 78, "/Image/Products/1.png", 100f, 20, "Knight-XL-Red", 300 },
                    { 79, "/Image/Products/1.png", 80f, 20, "Knight-L-Blue", 10 },
                    { 80, "/Image/Products/1.png", 200f, 20, "Knight-XL-Blue", 60 },
                    { 81, "/Image/Products/1.png", 120f, 21, "AmericanEagle-L-Red", 100 },
                    { 82, "/Image/Products/1.png", 100f, 21, "AmericanEagle-XL-Red", 50 },
                    { 83, "/Image/Products/1.png", 80f, 21, "AmericanEagle-L-Blue", 20 },
                    { 84, "/Image/Products/1.png", 200f, 21, "AmericanEagle-XL-Blue", 0 },
                    { 85, "/Image/Products/1.png", 120f, 22, "Knight-L-Red", 200 },
                    { 86, "/Image/Products/1.png", 100f, 22, "Knight-XL-Red", 300 },
                    { 87, "/Image/Products/1.png", 80f, 22, "Knight-L-Blue", 10 },
                    { 88, "/Image/Products/1.png", 200f, 22, "Knight-XL-Blue", 60 },
                    { 89, "/Image/Products/1.png", 120f, 23, "AmericanEagle-L-Red", 100 },
                    { 90, "/Image/Products/1.png", 100f, 23, "AmericanEagle-XL-Red", 50 },
                    { 91, "/Image/Products/1.png", 80f, 23, "AmericanEagle-L-Blue", 20 },
                    { 92, "/Image/Products/1.png", 200f, 23, "AmericanEagle-XL-Blue", 0 },
                    { 93, "/Image/Products/1.png", 120f, 24, "Knight-L-Red", 200 },
                    { 94, "/Image/Products/1.png", 100f, 24, "Knight-XL-Red", 300 },
                    { 95, "/Image/Products/1.png", 80f, 24, "Knight-L-Blue", 10 },
                    { 96, "/Image/Products/1.png", 200f, 24, "Knight-XL-Blue", 60 },
                    { 97, "/Image/Products/1.png", 120f, 25, "AmericanEagle-L-Red", 100 },
                    { 98, "/Image/Products/1.png", 100f, 25, "AmericanEagle-XL-Red", 50 },
                    { 99, "/Image/Products/1.png", 80f, 25, "AmericanEagle-L-Blue", 20 },
                    { 100, "/Image/Products/1.png", 200f, 25, "AmericanEagle-XL-Blue", 0 },
                    { 101, "/Image/Products/1.png", 120f, 26, "Knight-L-Red", 200 },
                    { 102, "/Image/Products/1.png", 100f, 26, "Knight-XL-Red", 300 },
                    { 103, "/Image/Products/1.png", 80f, 26, "Knight-L-Blue", 10 },
                    { 104, "/Image/Products/1.png", 200f, 26, "Knight-XL-Blue", 60 },
                    { 105, "/Image/Products/1.png", 120f, 27, "AmericanEagle-L-Red", 100 },
                    { 106, "/Image/Products/1.png", 100f, 27, "AmericanEagle-XL-Red", 50 },
                    { 107, "/Image/Products/1.png", 80f, 27, "AmericanEagle-L-Blue", 20 },
                    { 108, "/Image/Products/1.png", 200f, 27, "AmericanEagle-XL-Blue", 0 },
                    { 109, "/Image/Products/1.png", 120f, 28, "Knight-L-Red", 200 },
                    { 110, "/Image/Products/1.png", 100f, 28, "Knight-XL-Red", 300 },
                    { 111, "/Image/Products/1.png", 80f, 28, "Knight-L-Blue", 10 },
                    { 112, "/Image/Products/1.png", 200f, 28, "Knight-XL-Blue", 60 },
                    { 113, "/Image/Products/1.png", 120f, 29, "AmericanEagle-L-Red", 100 },
                    { 114, "/Image/Products/1.png", 100f, 29, "AmericanEagle-XL-Red", 50 },
                    { 115, "/Image/Products/1.png", 80f, 29, "AmericanEagle-L-Blue", 20 },
                    { 116, "/Image/Products/1.png", 200f, 29, "AmericanEagle-XL-Blue", 0 },
                    { 117, "/Image/Products/1.png", 120f, 30, "Knight-L-Red", 200 },
                    { 118, "/Image/Products/1.png", 100f, 30, "Knight-XL-Red", 300 },
                    { 119, "/Image/Products/1.png", 80f, 30, "Knight-L-Blue", 10 },
                    { 120, "/Image/Products/1.png", 200f, 30, "Knight-XL-Blue", 60 }
                });

            migrationBuilder.InsertData(
                table: "VariationOptions",
                columns: new[] { "Id", "Value", "VariationId" },
                values: new object[,]
                {
                    { 1, "Red", 1 },
                    { 2, "Blue", 1 },
                    { 3, "L", 2 },
                    { 4, "XL", 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductConfigurations",
                columns: new[] { "ProductItemId", "VariationOptionsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 4 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 2 },
                    { 4, 4 },
                    { 5, 1 },
                    { 5, 3 },
                    { 6, 1 },
                    { 6, 4 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 2 },
                    { 8, 4 },
                    { 9, 1 },
                    { 9, 3 },
                    { 10, 1 },
                    { 10, 4 },
                    { 11, 2 },
                    { 11, 3 },
                    { 12, 2 },
                    { 12, 4 },
                    { 13, 1 },
                    { 13, 3 },
                    { 14, 1 },
                    { 14, 4 },
                    { 15, 2 },
                    { 15, 3 },
                    { 16, 2 },
                    { 16, 4 },
                    { 17, 1 },
                    { 17, 3 },
                    { 18, 1 },
                    { 18, 4 },
                    { 19, 2 },
                    { 19, 3 },
                    { 20, 2 },
                    { 20, 4 },
                    { 21, 1 },
                    { 21, 3 },
                    { 22, 1 },
                    { 22, 4 },
                    { 23, 2 },
                    { 23, 3 },
                    { 24, 2 },
                    { 24, 4 },
                    { 25, 1 },
                    { 25, 3 },
                    { 26, 1 },
                    { 26, 4 },
                    { 27, 2 },
                    { 27, 3 },
                    { 28, 2 },
                    { 28, 4 },
                    { 29, 1 },
                    { 29, 3 },
                    { 30, 1 },
                    { 30, 4 },
                    { 31, 2 },
                    { 31, 3 },
                    { 32, 2 },
                    { 32, 4 },
                    { 33, 1 },
                    { 33, 3 },
                    { 34, 1 },
                    { 34, 4 },
                    { 35, 2 },
                    { 35, 3 },
                    { 36, 2 },
                    { 36, 4 },
                    { 37, 1 },
                    { 37, 3 },
                    { 38, 1 },
                    { 38, 4 },
                    { 39, 2 },
                    { 39, 3 },
                    { 40, 2 },
                    { 40, 4 },
                    { 41, 1 },
                    { 41, 3 },
                    { 42, 1 },
                    { 42, 4 },
                    { 43, 2 },
                    { 43, 3 },
                    { 44, 2 },
                    { 44, 4 },
                    { 45, 1 },
                    { 45, 3 },
                    { 46, 1 },
                    { 46, 4 },
                    { 47, 2 },
                    { 47, 3 },
                    { 48, 2 },
                    { 48, 4 },
                    { 49, 1 },
                    { 49, 3 },
                    { 50, 1 },
                    { 50, 4 },
                    { 51, 2 },
                    { 51, 3 },
                    { 52, 2 },
                    { 52, 4 },
                    { 53, 1 },
                    { 53, 3 },
                    { 54, 1 },
                    { 54, 4 },
                    { 55, 2 },
                    { 55, 3 },
                    { 56, 2 },
                    { 56, 4 },
                    { 57, 1 },
                    { 57, 3 },
                    { 58, 1 },
                    { 58, 4 },
                    { 59, 2 },
                    { 59, 3 },
                    { 60, 2 },
                    { 60, 4 },
                    { 61, 1 },
                    { 61, 3 },
                    { 62, 1 },
                    { 62, 4 },
                    { 63, 2 },
                    { 63, 3 },
                    { 64, 2 },
                    { 64, 4 },
                    { 65, 1 },
                    { 65, 3 },
                    { 66, 1 },
                    { 66, 4 },
                    { 67, 2 },
                    { 67, 3 },
                    { 68, 2 },
                    { 68, 4 },
                    { 69, 1 },
                    { 69, 3 },
                    { 70, 1 },
                    { 70, 4 },
                    { 71, 2 },
                    { 71, 3 },
                    { 72, 2 },
                    { 72, 4 },
                    { 73, 1 },
                    { 73, 3 },
                    { 74, 1 },
                    { 74, 4 },
                    { 75, 2 },
                    { 75, 3 },
                    { 76, 2 },
                    { 76, 4 },
                    { 77, 1 },
                    { 77, 3 },
                    { 78, 1 },
                    { 78, 4 },
                    { 79, 2 },
                    { 79, 3 },
                    { 80, 2 },
                    { 80, 4 },
                    { 81, 1 },
                    { 81, 3 },
                    { 82, 1 },
                    { 82, 4 },
                    { 83, 2 },
                    { 83, 3 },
                    { 84, 2 },
                    { 84, 4 },
                    { 85, 1 },
                    { 85, 3 },
                    { 86, 1 },
                    { 86, 4 },
                    { 87, 2 },
                    { 87, 3 },
                    { 88, 2 },
                    { 88, 4 },
                    { 89, 1 },
                    { 89, 3 },
                    { 90, 1 },
                    { 90, 4 },
                    { 91, 2 },
                    { 91, 3 },
                    { 92, 2 },
                    { 92, 4 },
                    { 93, 1 },
                    { 93, 3 },
                    { 94, 1 },
                    { 94, 4 },
                    { 95, 2 },
                    { 95, 3 },
                    { 96, 2 },
                    { 96, 4 },
                    { 97, 1 },
                    { 97, 3 },
                    { 98, 1 },
                    { 98, 4 },
                    { 99, 2 },
                    { 99, 3 },
                    { 100, 2 },
                    { 100, 4 },
                    { 101, 1 },
                    { 101, 3 },
                    { 102, 1 },
                    { 102, 4 },
                    { 103, 2 },
                    { 103, 3 },
                    { 104, 2 },
                    { 104, 4 },
                    { 105, 1 },
                    { 105, 3 },
                    { 106, 1 },
                    { 106, 4 },
                    { 107, 2 },
                    { 107, 3 },
                    { 108, 2 },
                    { 108, 4 },
                    { 109, 1 },
                    { 109, 3 },
                    { 110, 1 },
                    { 110, 4 },
                    { 111, 2 },
                    { 111, 3 },
                    { 112, 2 },
                    { 112, 4 },
                    { 113, 1 },
                    { 113, 3 },
                    { 114, 1 },
                    { 114, 4 },
                    { 115, 2 },
                    { 115, 3 },
                    { 116, 2 },
                    { 116, 4 },
                    { 117, 1 },
                    { 117, 3 },
                    { 118, 1 },
                    { 118, 4 },
                    { 119, 2 },
                    { 119, 3 },
                    { 120, 2 },
                    { 120, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductConfigurations_VariationOptionsId",
                table: "ProductConfigurations",
                column: "VariationOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_ProductId",
                table: "ProductItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VariationOptions_VariationId",
                table: "VariationOptions",
                column: "VariationId");

            migrationBuilder.CreateIndex(
                name: "IX_Variations_CategoryId",
                table: "Variations",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductConfigurations");

            migrationBuilder.DropTable(
                name: "ProductItems");

            migrationBuilder.DropTable(
                name: "VariationOptions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Variations");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

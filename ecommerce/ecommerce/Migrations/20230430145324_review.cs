using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class review : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Phone" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Star",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Star",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Star",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Star",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Star",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Star",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Star",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Star",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Star",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Star",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Star",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Star",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Star",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Star",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "Star",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "Star",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Star",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Star",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Star",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Star",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Star",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Star",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ShippingMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Fast", 20f });

            migrationBuilder.UpdateData(
                table: "ShippingMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Express", 50f });

            migrationBuilder.UpdateData(
                table: "ShippingMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Regular", 10f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Star" },
                values: new object[,]
                {
                    { 38, 9, "Apple iPhone 14 Pro Max, 1TB, Space Black - Unlocked (Renewed Premium)", "/Image/Products/25.jpg", "Apple iPhone 14 Pro Max", 4 },
                    { 39, 9, "Apple iPhone 11, 64GB, Black - Unlocked (Renewed)", "/Image/Products/26.jpg", "Apple iPhone 11", 1 },
                    { 40, 9, "Apple iPhone XR, 64GB, Black - Unlocked (Renewed)", "/Image/Products/27.jpg", "Apple iPhone XR", 2 },
                    { 41, 9, "Apple iPhone 12 Mini, 64GB, White - Unlocked (Renewed Premium)", "/Image/Products/28.jpg", "Apple iPhone 12 Mini", 5 },
                    { 42, 9, "Apple iPhone 12, 64GB, Green - Fully Unlocked (Renewed)", "/Image/Products/29.jpg", "Apple iPhone 12", 3 },
                    { 43, 9, "Apple iPhone XS Max, US Version, 64GB, Space Gray - Unlocked (Renewed)", "/Image/Products/30.jpg", "Apple iPhone XS Max", 4 },
                    { 44, 9, "Apple iPhone 13, 128GB, Product Red - Unlocked (Renewed Premium)", "/Image/Products/31.jpg", "Apple iPhone 13", 1 },
                    { 45, 9, "Apple iPhone XS, US Version, 256GB, Space Gray - Unlocked (Renewed)", "/Image/Products/32.jpg", "Apple iPhone XS", 2 },
                    { 46, 9, "Apple iPhone 13 Pro Max, 128GB, Sierra Blue - Unlocked (Renewed Premium)", "/Image/Products/33.jpg", "Apple iPhone 13 Pro Max", 5 },
                    { 47, 9, "Apple iPhone 14 Pro, 1TB, Deep Purple - Unlocked (Renewed Premium)", "/Image/Products/34.jpg", "Apple iPhone 14 Pro", 3 },
                    { 48, 9, " Apple iPhone 13 Pro, 128GB, Gold - Unlocked (Renewed Premium)", "/Image/Products/35.jpg", "Apple iPhone 13 Pro", 4 },
                    { 49, 9, "Apple iPhone 12 Pro Max, 256GB, Pacific Blue - Unlocked (Renewed Premium)\n", "/Image/Products/36.jpg", "Apple iPhone 12 Pro Max", 1 }
                });

            migrationBuilder.InsertData(
                table: "Variations",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 3, 9, "Color" },
                    { 4, 9, "Space" }
                });

            migrationBuilder.InsertData(
                table: "ProductItems",
                columns: new[] { "Id", "Image", "Price", "ProductId", "SKU", "StockQty" },
                values: new object[,]
                {
                    { 121, "/Image/Products/25.jpg", 1500f, 38, "Apple iPhone 14 Pro Max-1000-Black", 50 },
                    { 122, "/Image/Products/25.jpg", 1200f, 38, "Apple iPhone 14 Pro Max-500-Black", 120 },
                    { 123, "/Image/Products/25.jpg", 1000f, 38, "Apple iPhone 14 Pro Max-265-Black", 40 },
                    { 124, "/Image/Products/25.jpg", 1500f, 38, "Apple iPhone 14 Pro Max-1000-Gray", 60 },
                    { 125, "/Image/Products/25.jpg", 1200f, 38, "Apple iPhone 14 Pro Max-500-Gray", 8 },
                    { 126, "/Image/Products/25.jpg", 1000f, 38, "Apple iPhone 14 Pro Max-265-Gray", 40 },
                    { 127, "/Image/Products/25.jpg", 1500f, 38, "Apple iPhone 14 Pro Max-1000-Red", 60 },
                    { 128, "/Image/Products/25.jpg", 1200f, 38, "Apple iPhone 14 Pro Max-500-Red", 170 },
                    { 129, "/Image/Products/25.jpg", 1000f, 38, "Apple iPhone 14 Pro Max-265-Red", 200 },
                    { 130, "/Image/Products/26.jpg", 300f, 39, "Apple iPhone 11-64-Black", 50 },
                    { 131, "/Image/Products/26.jpg", 420f, 39, "Apple iPhone 11-128-Black", 120 },
                    { 132, "/Image/Products/26.jpg", 500f, 39, "Apple iPhone 11-265-Black", 40 },
                    { 133, "/Image/Products/26.jpg", 300f, 39, "Apple iPhone 11-64-Gold", 60 },
                    { 134, "/Image/Products/26.jpg", 420f, 39, "Apple iPhone 11-128-Gold", 8 },
                    { 135, "/Image/Products/26.jpg", 500f, 39, "Apple iPhone 11-265-Gold", 40 },
                    { 136, "/Image/Products/26.jpg", 300f, 39, "Apple iPhone 11-64-Red", 60 },
                    { 137, "/Image/Products/26.jpg", 420f, 39, "Apple iPhone 11-128-Red", 170 },
                    { 138, "/Image/Products/26.jpg", 500f, 39, "Apple iPhone 11-265-Red", 200 },
                    { 139, "/Image/Products/27.jpg", 224f, 40, "Apple iPhone XR-64-Black", 50 },
                    { 140, "/Image/Products/27.jpg", 300f, 40, "Apple iPhone XR-128-Black", 120 },
                    { 141, "/Image/Products/27.jpg", 410f, 40, "Apple iPhone XR-265-Black", 40 },
                    { 142, "/Image/Products/27.jpg", 224f, 40, "Apple iPhone XR-64-Gold", 60 },
                    { 143, "/Image/Products/27.jpg", 300f, 40, "Apple iPhone XR-128-Gold", 8 },
                    { 144, "/Image/Products/27.jpg", 410f, 40, "Apple iPhone XR-265-Gold", 40 },
                    { 145, "/Image/Products/27.jpg", 224f, 40, "Apple iPhone XR-64-Gray", 60 },
                    { 146, "/Image/Products/27.jpg", 300f, 40, "Apple iPhone XR-128-Gray", 170 },
                    { 147, "/Image/Products/27.jpg", 410f, 40, "Apple iPhone XR-265-Gray", 200 },
                    { 148, "/Image/Products/28.jpg", 390f, 41, "Apple iPhone 12 Mini-64-Black", 50 },
                    { 149, "/Image/Products/28.jpg", 450f, 41, "Apple iPhone 12 Mini-128-Black", 120 },
                    { 150, "/Image/Products/28.jpg", 520f, 41, "Apple iPhone 12 Mini-265-Black", 40 },
                    { 151, "/Image/Products/28.jpg", 390f, 41, "Apple iPhone 12 Mini-64-Gold", 60 },
                    { 152, "/Image/Products/28.jpg", 450f, 41, "Apple iPhone 12 Mini-128-Gold", 8 },
                    { 153, "/Image/Products/28.jpg", 520f, 41, "Apple iPhone 12 Mini-265-Gold", 40 },
                    { 154, "/Image/Products/28.jpg", 390f, 41, "Apple iPhone 12 Mini-64-Gray", 60 },
                    { 155, "/Image/Products/28.jpg", 450f, 41, "Apple iPhone 12 Mini-128-Gray", 170 },
                    { 156, "/Image/Products/28.jpg", 520f, 41, "Apple iPhone 12 Mini-265-Gray", 200 },
                    { 157, "/Image/Products/29.jpg", 450f, 42, "Apple iPhone 12-64-Black", 50 },
                    { 158, "/Image/Products/29.jpg", 500f, 42, "Apple iPhone 12 -128-Black", 120 },
                    { 159, "/Image/Products/29.jpg", 550f, 42, "Apple iPhone 12 -265-Black", 40 },
                    { 160, "/Image/Products/29.jpg", 450f, 42, "Apple iPhone 12 -64-Gold", 60 },
                    { 161, "/Image/Products/29.jpg", 500f, 42, "Apple iPhone 12 -128-Gold", 8 },
                    { 162, "/Image/Products/29.jpg", 550f, 42, "Apple iPhone 12 -265-Gold", 40 },
                    { 163, "/Image/Products/29.jpg", 450f, 42, "Apple iPhone 12 -64-Gray", 60 },
                    { 164, "/Image/Products/29.jpg", 500f, 42, "Apple iPhone 12 -128-Gray", 170 },
                    { 165, "/Image/Products/29.jpg", 550f, 42, "Apple iPhone 12 -265-Gray", 200 },
                    { 166, "/Image/Products/30.jpg", 270f, 43, "Apple iPhone XS Max-64-Black", 50 },
                    { 167, "/Image/Products/30.jpg", 350f, 43, "Apple iPhone XS Max -128-Black", 120 },
                    { 168, "/Image/Products/30.jpg", 430f, 43, "Apple iPhone XS Max -265-Black", 40 },
                    { 169, "/Image/Products/30.jpg", 270f, 43, "Apple iPhone XS Max -64-Gold", 60 },
                    { 170, "/Image/Products/30.jpg", 350f, 43, "Apple iPhone XS Max -128-Gold", 8 },
                    { 171, "/Image/Products/30.jpg", 430f, 43, "Apple iPhone XS Max -265-Gold", 40 },
                    { 172, "/Image/Products/30.jpg", 270f, 43, "Apple iPhone XS Max -64-Gray", 60 },
                    { 173, "/Image/Products/30.jpg", 350f, 43, "Apple iPhone XS Max -128-Gray", 170 },
                    { 174, "/Image/Products/30.jpg", 430f, 43, "Apple iPhone XS Max -265-Gray", 200 },
                    { 175, "/Image/Products/31.jpg", 668f, 44, "Apple iPhone 13-512-Black", 50 },
                    { 176, "/Image/Products/31.jpg", 770f, 44, "Apple iPhone 13 -128-Black", 120 },
                    { 177, "/Image/Products/31.jpg", 830f, 44, "Apple iPhone 13 -265-Black", 40 },
                    { 178, "/Image/Products/31.jpg", 668f, 44, "Apple iPhone 13 -512-Gold", 60 },
                    { 179, "/Image/Products/31.jpg", 770f, 44, "Apple iPhone 13 -128-Gold", 8 },
                    { 180, "/Image/Products/31.jpg", 830f, 44, "Apple iPhone 13 -265-Gold", 40 },
                    { 181, "/Image/Products/31.jpg", 668f, 44, "Apple iPhone 13 -512-Gray", 60 },
                    { 182, "/Image/Products/31.jpg", 770f, 44, "Apple iPhone 13 -128-Gray", 170 },
                    { 183, "/Image/Products/31.jpg", 830f, 44, "Apple iPhone 13 -265-Gray", 200 },
                    { 184, "/Image/Products/32.jpg", 270f, 45, "Apple iPhone XS -64-Black", 50 },
                    { 185, "/Image/Products/32.jpg", 350f, 45, "Apple iPhone XS  -128-Black", 120 },
                    { 186, "/Image/Products/32.jpg", 430f, 45, "Apple iPhone XS  -265-Black", 40 },
                    { 187, "/Image/Products/32.jpg", 270f, 45, "Apple iPhone XS  -64-Gold", 60 },
                    { 188, "/Image/Products/32.jpg", 350f, 45, "Apple iPhone XS  -128-Gold", 8 },
                    { 189, "/Image/Products/32.jpg", 430f, 45, "Apple iPhone XS  -265-Gold", 40 },
                    { 190, "/Image/Products/32.jpg", 270f, 45, "Apple iPhone XS  -64-Gray", 60 },
                    { 191, "/Image/Products/32.jpg", 350f, 45, "Apple iPhone XS  -128-Gray", 170 },
                    { 192, "/Image/Products/32.jpg", 430f, 45, "Apple iPhone XS  -265-Gray", 200 },
                    { 193, "/Image/Products/33.jpg", 1200f, 46, "Apple iPhone 13 Max-512-Black", 50 },
                    { 194, "/Image/Products/33.jpg", 940f, 46, "Apple iPhone 13 Max -128-Black", 120 },
                    { 195, "/Image/Products/33.jpg", 1050f, 46, "Apple iPhone 13 Max -265-Black", 40 },
                    { 196, "/Image/Products/33.jpg", 1200f, 46, "Apple iPhone 13 Max -512-Gold", 60 },
                    { 197, "/Image/Products/33.jpg", 940f, 46, "Apple iPhone 13 Max -128-Gold", 8 },
                    { 198, "/Image/Products/33.jpg", 1050f, 46, "Apple iPhone 13 Max -265-Gold", 40 },
                    { 199, "/Image/Products/33.jpg", 1200f, 46, "Apple iPhone 13 Max -512-Gray", 60 },
                    { 200, "/Image/Products/33.jpg", 940f, 46, "Apple iPhone 13 Max -128-Gray", 170 },
                    { 201, "/Image/Products/33.jpg", 1050f, 46, "Apple iPhone 13 Max -265-Gray", 200 },
                    { 202, "/Image/Products/34.jpg", 1300f, 47, "Apple iPhone 14 Pro-1000-Black", 50 },
                    { 203, "/Image/Products/34.jpg", 1150f, 47, "Apple iPhone 14 Pro-500-Black", 120 },
                    { 204, "/Image/Products/34.jpg", 1000f, 47, "Apple iPhone 14 Pro-265-Black", 40 },
                    { 205, "/Image/Products/34.jpg", 1300f, 47, "Apple iPhone 14 Pro-1000-Gray", 60 },
                    { 206, "/Image/Products/34.jpg", 1150f, 47, "Apple iPhone 14 Pro-500-Gray", 8 },
                    { 207, "/Image/Products/34.jpg", 1000f, 47, "Apple iPhone 14 Pro-265-Gray", 40 },
                    { 208, "/Image/Products/34.jpg", 1300f, 47, "Apple iPhone 14 Pro-1000-Red", 60 },
                    { 209, "/Image/Products/34.jpg", 1150f, 47, "Apple iPhone 14 Pro-500-Red", 170 },
                    { 210, "/Image/Products/34.jpg", 1000f, 47, "Apple iPhone 14 Pro-265-Red", 200 },
                    { 211, "/Image/Products/35.jpg", 980f, 48, "Apple iPhone 13 Pro-512-Black", 50 },
                    { 212, "/Image/Products/35.jpg", 850f, 48, "Apple iPhone 13 Pro -128-Black", 120 },
                    { 213, "/Image/Products/35.jpg", 740f, 48, "Apple iPhone 13 Pro -265-Black", 40 },
                    { 214, "/Image/Products/35.jpg", 980f, 48, "Apple iPhone 13 Pro -512-Gold", 60 },
                    { 215, "/Image/Products/35.jpg", 850f, 48, "Apple iPhone 13 Pro -128-Gold", 8 },
                    { 216, "/Image/Products/35.jpg", 740f, 48, "Apple iPhone 13 Pro -265-Gold", 40 },
                    { 217, "/Image/Products/35.jpg", 980f, 48, "Apple iPhone 13 Pro -512-Gray", 60 },
                    { 218, "/Image/Products/35.jpg", 850f, 48, "Apple iPhone 13 Pro -128-Gray", 170 },
                    { 219, "/Image/Products/35.jpg", 740f, 48, "Apple iPhone 13 Pro -265-Gray", 200 },
                    { 220, "/Image/Products/36.jpg", 1150f, 49, "Apple iPhone 12 Pro Max-512-Black", 50 },
                    { 221, "/Image/Products/36.jpg", 850f, 49, "Apple iPhone 12 Pro Max -128-Black", 120 },
                    { 222, "/Image/Products/36.jpg", 800f, 49, "Apple iPhone 12 Pro Max -265-Black", 40 },
                    { 223, "/Image/Products/36.jpg", 1150f, 49, "Apple iPhone 12 Pro Max -512-Gold", 60 },
                    { 224, "/Image/Products/36.jpg", 850f, 49, "Apple iPhone 12 Pro Max -128-Gold", 8 },
                    { 225, "/Image/Products/36.jpg", 800f, 49, "Apple iPhone 12 Pro Max -265-Gold", 40 },
                    { 226, "/Image/Products/36.jpg", 1150f, 49, "Apple iPhone 12 Pro Max -512-Gray", 60 },
                    { 227, "/Image/Products/36.jpg", 850f, 49, "Apple iPhone 12 Pro Max -128-Gray", 170 },
                    { 228, "/Image/Products/36.jpg", 800f, 49, "Apple iPhone 12 Pro Max -265-Gray", 200 }
                });

            migrationBuilder.InsertData(
                table: "VariationOptions",
                columns: new[] { "Id", "Value", "VariationId" },
                values: new object[,]
                {
                    { 5, "64", 4 },
                    { 6, "128", 4 },
                    { 7, "265", 4 },
                    { 8, "512", 4 },
                    { 9, "1000", 4 },
                    { 10, "Gold", 3 },
                    { 11, "Black", 3 },
                    { 12, "Gray", 3 },
                    { 13, "Pacific blue", 3 },
                    { 14, "Red", 3 }
                });

            migrationBuilder.InsertData(
                table: "ProductConfigurations",
                columns: new[] { "ProductItemId", "VariationOptionsId" },
                values: new object[,]
                {
                    { 121, 9 },
                    { 121, 11 },
                    { 122, 8 },
                    { 122, 11 },
                    { 123, 7 },
                    { 123, 11 },
                    { 124, 9 },
                    { 124, 12 },
                    { 125, 8 },
                    { 125, 12 },
                    { 126, 7 },
                    { 126, 12 },
                    { 127, 9 },
                    { 127, 14 },
                    { 128, 8 },
                    { 128, 14 },
                    { 129, 7 },
                    { 129, 14 },
                    { 130, 5 },
                    { 130, 11 },
                    { 131, 6 },
                    { 131, 11 },
                    { 132, 7 },
                    { 132, 11 },
                    { 133, 5 },
                    { 133, 10 },
                    { 134, 6 },
                    { 134, 10 },
                    { 135, 7 },
                    { 135, 10 },
                    { 136, 5 },
                    { 136, 14 },
                    { 137, 6 },
                    { 137, 14 },
                    { 138, 7 },
                    { 138, 14 },
                    { 139, 5 },
                    { 139, 11 },
                    { 140, 6 },
                    { 140, 11 },
                    { 141, 7 },
                    { 141, 11 },
                    { 142, 5 },
                    { 142, 10 },
                    { 143, 6 },
                    { 143, 10 },
                    { 144, 7 },
                    { 144, 10 },
                    { 145, 5 },
                    { 145, 12 },
                    { 146, 6 },
                    { 146, 12 },
                    { 147, 7 },
                    { 147, 12 },
                    { 148, 5 },
                    { 148, 11 },
                    { 149, 6 },
                    { 149, 11 },
                    { 150, 7 },
                    { 150, 11 },
                    { 151, 5 },
                    { 151, 10 },
                    { 152, 6 },
                    { 152, 10 },
                    { 153, 7 },
                    { 153, 10 },
                    { 154, 5 },
                    { 154, 12 },
                    { 155, 6 },
                    { 155, 12 },
                    { 156, 7 },
                    { 156, 12 },
                    { 157, 5 },
                    { 157, 11 },
                    { 158, 6 },
                    { 158, 11 },
                    { 159, 7 },
                    { 159, 11 },
                    { 160, 5 },
                    { 160, 10 },
                    { 161, 6 },
                    { 161, 10 },
                    { 162, 7 },
                    { 162, 10 },
                    { 163, 5 },
                    { 163, 12 },
                    { 164, 6 },
                    { 164, 12 },
                    { 165, 7 },
                    { 165, 12 },
                    { 166, 5 },
                    { 166, 11 },
                    { 167, 6 },
                    { 167, 11 },
                    { 168, 7 },
                    { 168, 11 },
                    { 169, 5 },
                    { 169, 10 },
                    { 170, 6 },
                    { 170, 10 },
                    { 171, 7 },
                    { 171, 10 },
                    { 172, 5 },
                    { 172, 12 },
                    { 173, 6 },
                    { 173, 12 },
                    { 174, 7 },
                    { 174, 12 },
                    { 175, 8 },
                    { 175, 11 },
                    { 176, 6 },
                    { 176, 11 },
                    { 177, 7 },
                    { 177, 11 },
                    { 178, 8 },
                    { 178, 10 },
                    { 179, 6 },
                    { 179, 10 },
                    { 180, 7 },
                    { 180, 10 },
                    { 181, 8 },
                    { 181, 12 },
                    { 182, 6 },
                    { 182, 12 },
                    { 183, 7 },
                    { 183, 12 },
                    { 184, 5 },
                    { 184, 11 },
                    { 185, 6 },
                    { 185, 11 },
                    { 186, 7 },
                    { 186, 11 },
                    { 187, 5 },
                    { 187, 10 },
                    { 188, 6 },
                    { 188, 10 },
                    { 189, 7 },
                    { 189, 10 },
                    { 190, 5 },
                    { 190, 12 },
                    { 191, 6 },
                    { 191, 12 },
                    { 192, 7 },
                    { 192, 12 },
                    { 193, 8 },
                    { 193, 11 },
                    { 194, 6 },
                    { 194, 11 },
                    { 195, 7 },
                    { 195, 11 },
                    { 196, 8 },
                    { 196, 10 },
                    { 197, 6 },
                    { 197, 10 },
                    { 198, 7 },
                    { 198, 10 },
                    { 199, 8 },
                    { 199, 12 },
                    { 200, 6 },
                    { 200, 12 },
                    { 201, 7 },
                    { 201, 12 },
                    { 202, 9 },
                    { 202, 11 },
                    { 203, 8 },
                    { 203, 11 },
                    { 204, 7 },
                    { 204, 11 },
                    { 205, 9 },
                    { 205, 12 },
                    { 206, 8 },
                    { 206, 12 },
                    { 207, 7 },
                    { 207, 12 },
                    { 208, 9 },
                    { 208, 14 },
                    { 209, 8 },
                    { 209, 14 },
                    { 210, 7 },
                    { 210, 14 },
                    { 211, 8 },
                    { 211, 11 },
                    { 212, 6 },
                    { 212, 11 },
                    { 213, 7 },
                    { 213, 11 },
                    { 214, 8 },
                    { 214, 10 },
                    { 215, 6 },
                    { 215, 10 },
                    { 216, 7 },
                    { 216, 10 },
                    { 217, 8 },
                    { 217, 12 },
                    { 218, 6 },
                    { 218, 12 },
                    { 219, 7 },
                    { 219, 12 },
                    { 220, 8 },
                    { 221, 6 },
                    { 221, 11 },
                    { 222, 7 },
                    { 222, 11 },
                    { 223, 8 },
                    { 223, 11 },
                    { 224, 6 },
                    { 224, 10 },
                    { 225, 7 },
                    { 225, 10 },
                    { 226, 10 },
                    { 227, 8 },
                    { 227, 12 },
                    { 228, 6 },
                    { 228, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_ProductId",
                table: "Review",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 121, 9 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 121, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 122, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 122, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 123, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 123, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 124, 9 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 124, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 125, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 125, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 126, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 126, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 127, 9 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 127, 14 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 128, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 128, 14 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 129, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 129, 14 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 130, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 130, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 131, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 131, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 132, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 132, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 133, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 133, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 134, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 134, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 135, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 135, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 136, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 136, 14 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 137, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 137, 14 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 138, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 138, 14 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 139, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 139, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 140, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 140, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 141, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 141, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 142, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 142, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 143, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 143, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 144, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 144, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 145, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 145, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 146, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 146, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 147, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 147, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 148, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 148, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 149, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 149, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 150, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 150, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 151, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 151, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 152, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 152, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 153, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 153, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 154, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 154, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 155, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 155, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 156, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 156, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 157, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 157, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 158, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 158, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 159, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 159, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 160, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 160, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 161, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 161, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 162, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 162, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 163, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 163, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 164, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 164, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 165, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 165, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 166, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 166, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 167, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 167, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 168, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 168, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 169, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 169, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 170, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 170, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 171, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 171, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 172, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 172, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 173, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 173, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 174, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 174, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 175, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 175, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 176, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 176, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 177, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 177, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 178, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 178, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 179, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 179, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 180, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 180, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 181, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 181, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 182, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 182, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 183, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 183, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 184, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 184, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 185, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 185, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 186, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 186, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 187, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 187, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 188, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 188, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 189, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 189, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 190, 5 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 190, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 191, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 191, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 192, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 192, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 193, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 193, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 194, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 194, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 195, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 195, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 196, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 196, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 197, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 197, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 198, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 198, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 199, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 199, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 200, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 200, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 201, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 201, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 202, 9 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 202, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 203, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 203, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 204, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 204, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 205, 9 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 205, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 206, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 206, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 207, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 207, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 208, 9 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 208, 14 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 209, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 209, 14 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 210, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 210, 14 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 211, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 211, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 212, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 212, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 213, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 213, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 214, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 214, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 215, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 215, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 216, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 216, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 217, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 217, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 218, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 218, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 219, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 219, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 220, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 221, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 221, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 222, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 222, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 223, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 223, 11 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 224, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 224, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 225, 7 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 225, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 226, 10 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 227, 8 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 227, 12 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 228, 6 });

            migrationBuilder.DeleteData(
                table: "ProductConfigurations",
                keyColumns: new[] { "ProductItemId", "VariationOptionsId" },
                keyValues: new object[] { 228, 12 });

            migrationBuilder.DeleteData(
                table: "VariationOptions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "VariationOptions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VariationOptions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VariationOptions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VariationOptions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VariationOptions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VariationOptions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VariationOptions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VariationOptions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VariationOptions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Variations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Variations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Star",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Star",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ShippingMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Regular", 10f });

            migrationBuilder.UpdateData(
                table: "ShippingMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Fast", 20f });

            migrationBuilder.UpdateData(
                table: "ShippingMethods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Express", 50f });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class addCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_UserId",
                table: "Addresses");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Addresses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "T-shirt");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "trousers ");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Shoes");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "socks" },
                    { 5, "Watch" },
                    { 6, "shirt" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Hero Basic mens Round Neck Undershirt", "/Image/Products/3.jpg", "Hero Basic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Romba Men's Summer Text Sleeve Cotton T Shirt", "/Image/Products/4.jpg", "Romba" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Andora Mens 33S22M30333 T-Shirt", "/Image/Products/5.jpg", "Andora" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "CAESAR Mens MensSport T-Shirt With Short Sleeves MensSport T-Shirt With Short Sleeves", "/Image/Products/6.jpg", "CAESAR" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Nexus Original Cotton T-Shirt", "/Image/Products/7.jpg", "Nexus" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Ravin EG Mens Ravin Chest Printed Cotton T-Shirt For Men S22M048 T-Shirt", "/Image/Products/8.jpg", "Ravin EG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "CAESAR Mens Mens Printed Round Neck T-Shirt T-Shirt", "/Image/Products/9.jpg", "CAESAR" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "adidas Mens Train Essentials Seasonal Logo Training T-Shirt TRAINING T-SHIRTS for Men T-Shirt", "/Image/Products/10.jpg", "adidas" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Adidas linear beach-bit short sleeve graphic t-shirt t-shirts for men", "/Image/Products/11.jpg", "adidas" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "BlackEdition Over size snake T-shirt", "/Image/Products/12.jpg", "Generic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Hero Basic mens Round Neck Undershirt", "/Image/Products/3.jpg", "Hero Basic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Romba Men's Summer Text Sleeve Cotton T Shirt", "/Image/Products/4.jpg", "Romba" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Andora Mens 33S22M30333 T-Shirt", "/Image/Products/5.jpg", "Andora" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "CAESAR Mens MensSport T-Shirt With Short Sleeves MensSport T-Shirt With Short Sleeves", "/Image/Products/6.jpg", "CAESAR" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Nexus Original Cotton T-Shirt", "/Image/Products/7.jpg", "Nexus" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Ravin EG Mens Ravin Chest Printed Cotton T-Shirt For Men S22M048 T-Shirt", "/Image/Products/8.jpg", "Ravin EG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "CAESAR Mens Mens Printed Round Neck T-Shirt T-Shirt", "/Image/Products/9.jpg", "CAESAR" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "adidas Mens Train Essentials Seasonal Logo Training T-Shirt TRAINING T-SHIRTS for Men T-Shirt", "/Image/Products/10.jpg", "adidas" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Adidas linear beach-bit short sleeve graphic t-shirt t-shirts for men", "/Image/Products/11.jpg", "adidas" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "BlackEdition Over size snake T-shirt", "/Image/Products/12.jpg", "Generic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Hero Basic mens Round Neck Undershirt", "/Image/Products/3.jpg", "Hero Basic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Romba Men's Summer Text Sleeve Cotton T Shirt", "/Image/Products/4.jpg", "Romba" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Andora Mens 33S22M30333 T-Shirt", "/Image/Products/5.jpg", "Andora" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "CAESAR Mens MensSport T-Shirt With Short Sleeves MensSport T-Shirt With Short Sleeves", "/Image/Products/6.jpg", "CAESAR" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 31, 2, "HIGH QUALITY Classic-fit Men's Pants for Gentleman", "/Image/Products/13.jpg", "BLACK TIGER" },
                    { 32, 3, "Mintra CAI Women Shoes", "/Image/Products/14.jpg", "Mintra" },
                    { 33, 4, "STITCH mens Pack of 5 Lycra Ankle Socks", "/Image/Products/15.jpg", "STITCH" },
                    { 34, 5, "SEIKO QUARTZ Metal Band Analg Watch for Men BLUE Dial SUR399P1", "/Image/Products/16.jpg", "SEIKO" },
                    { 35, 6, "Jamila Women Stripped oversized shirt with two pockets", "/Image/Products/17.jpg", "Jamila" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_UserId",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Addresses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Tshirt");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Phone");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight" });

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}

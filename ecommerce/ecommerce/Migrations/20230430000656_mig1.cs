using System;
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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Reduction = table.Column<float>(type: "real", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                    Star = table.Column<int>(type: "int", nullable: false),
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
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit_Number = table.Column<int>(type: "int", nullable: false),
                    Street_Number = table.Column<int>(type: "int", nullable: false),
                    Address_line1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_line2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postal_Code = table.Column<int>(type: "int", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    Country_Id = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Addresses_Countries_Country_Id",
                        column: x => x.Country_Id,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
                    Provider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<double>(type: "float", nullable: false),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserProduct",
                columns: table => new
                {
                    ApplicationUsersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserProduct", x => new { x.ApplicationUsersId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserProduct_AspNetUsers_ApplicationUsersId",
                        column: x => x.ApplicationUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ApplicationUserProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
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
                name: "ShopOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingAddressId = table.Column<int>(type: "int", nullable: false),
                    ShippingMethodId = table.Column<int>(type: "int", nullable: false),
                    OrderTotal = table.Column<float>(type: "real", nullable: false),
                    OrderStatusId = table.Column<int>(type: "int", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopOrders_Addresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShopOrders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShopOrders_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShopOrders_ShippingMethods_ShippingMethodId",
                        column: x => x.ShippingMethodId,
                        principalTable: "ShippingMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CartProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartProducts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CartProducts_ProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItems",
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

            migrationBuilder.CreateTable(
                name: "OrderLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductItemId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLines_ProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrderLines_ShopOrders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "ShopOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "T-shirt" },
                    { 2, "trousers " },
                    { 3, "Shoes" },
                    { 4, "Socks" },
                    { 5, "Watch" },
                    { 6, "Shirt" },
                    { 7, "Washer" },
                    { 8, "Fryer" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Country_Name" },
                values: new object[,]
                {
                    { 1, "Afghanistan" },
                    { 2, "Albania" },
                    { 3, "Algeria" },
                    { 4, "Andorra" },
                    { 5, "Angola" },
                    { 6, "Antigua and Barbuda" },
                    { 7, "Argentina" },
                    { 8, "Armenia" },
                    { 9, "Austria" },
                    { 10, "Azerbaijan" },
                    { 11, "Bahrain" },
                    { 12, "Bangladesh" },
                    { 13, "Barbados" },
                    { 14, "Belarus" },
                    { 15, "Belgium" },
                    { 16, "Belize" },
                    { 17, "Benin" },
                    { 18, "Bhutan" },
                    { 19, "Bolivia" },
                    { 20, "Bosnia and Herzegovina" },
                    { 21, "Botswana" },
                    { 22, "Brazil" },
                    { 23, "Brunei" },
                    { 24, "Bulgaria" },
                    { 25, "Burkina Faso" },
                    { 26, "Burundi" },
                    { 27, "Cabo Verde" },
                    { 28, "Cambodia" },
                    { 29, "Cameroon" },
                    { 30, "Canada" },
                    { 31, "Central African Republic" },
                    { 32, "Chad" },
                    { 33, "Channel Islands" },
                    { 34, "Chile" },
                    { 35, "China" },
                    { 36, "Colombia" },
                    { 37, "Comoros" },
                    { 38, "Congo" },
                    { 39, "Costa Rica" },
                    { 40, "Côte d'Ivoire" },
                    { 41, "Croatia" },
                    { 42, "Cuba" },
                    { 43, "Cyprus" },
                    { 44, "Czech Republic" },
                    { 45, "Denmark" },
                    { 46, "Djibouti" },
                    { 47, "Dominica" },
                    { 48, "Dominican Republic" },
                    { 49, "DR Congo" },
                    { 50, "Ecuador" },
                    { 51, "Egypt" },
                    { 52, "El Salvador" },
                    { 53, "Equatorial Guinea" },
                    { 54, "Eritrea" },
                    { 55, "Estonia" },
                    { 56, "Eswatini" },
                    { 57, "Ethiopia" },
                    { 58, "Faeroe Islands" },
                    { 59, "Finland" },
                    { 60, "France" },
                    { 61, "French Guiana" },
                    { 62, "Gabon" },
                    { 63, "Gambia" },
                    { 64, "Georgia" },
                    { 65, "Germany" },
                    { 66, "Ghana" },
                    { 67, "Gibraltar" },
                    { 68, "Greece" },
                    { 69, "Grenada" },
                    { 70, "Guatemala" },
                    { 71, "Guinea" },
                    { 72, "Guinea-Bissau" },
                    { 73, "Guyana" },
                    { 74, "Haiti" },
                    { 75, "Holy See" },
                    { 76, "Honduras" },
                    { 77, "Hong Kong" },
                    { 78, "Hungary" },
                    { 79, "Iceland" },
                    { 80, "India" },
                    { 81, "Indonesia" },
                    { 82, "Iran" },
                    { 83, "Iraq" },
                    { 84, "Ireland" },
                    { 85, "Isle of Man" },
                    { 86, "Israel" },
                    { 87, "Italy" },
                    { 88, "Jamaica" },
                    { 89, "Japan" },
                    { 90, "Jordan" },
                    { 91, "Kazakhstan" },
                    { 92, "Kenya" },
                    { 93, "Kuwait" },
                    { 94, "Kyrgyzstan" },
                    { 95, "Laos" },
                    { 96, "Latvia" },
                    { 97, "Lebanon" },
                    { 98, "Lesotho" },
                    { 99, "Liberia" },
                    { 100, "Libya" },
                    { 101, "Liechtenstein" },
                    { 102, "Lithuania" },
                    { 103, "Luxembourg" },
                    { 104, "Macao" },
                    { 105, "Madagascar" },
                    { 106, "Malawi" },
                    { 107, "Malaysia" },
                    { 108, "Maldives" },
                    { 109, "Mali" },
                    { 110, "Malta" },
                    { 111, "Mauritania" },
                    { 112, "Mauritius" },
                    { 113, "Mayotte" },
                    { 114, "Mexico" },
                    { 115, "Moldova" },
                    { 116, "Monaco" },
                    { 117, "Mongolia" },
                    { 118, "Montenegro" },
                    { 119, "Morocco" },
                    { 120, "Mozambique" },
                    { 121, "Myanmar" },
                    { 122, "Namibia" },
                    { 123, "Nepal" },
                    { 124, "Netherlands" },
                    { 125, "Nicaragua" },
                    { 126, "Niger" },
                    { 127, "Nigeria" },
                    { 128, "North Korea" },
                    { 129, "North Macedonia" },
                    { 130, "Norway" },
                    { 131, "Oman" },
                    { 132, "Pakistan" },
                    { 133, "Panama" },
                    { 134, "Paraguay" },
                    { 135, "Peru" },
                    { 136, "Philippines" },
                    { 137, "Poland" },
                    { 138, "Portugal" },
                    { 139, "Qatar" },
                    { 140, "Réunion" },
                    { 141, "Romania" },
                    { 142, "Russia" },
                    { 143, "Rwanda" },
                    { 144, "Saint Helena" },
                    { 145, "Saint Kitts and Nevis" },
                    { 146, "Saint Lucia" },
                    { 147, "Saint Vincent and the Grenadines" },
                    { 148, "San Marino" },
                    { 149, "Sao Tome & Principe" },
                    { 150, "Saudi Arabia" },
                    { 151, "Senegal" },
                    { 152, "Serbia" },
                    { 153, "Seychelles" },
                    { 154, "Sierra Leone" },
                    { 155, "Singapore" },
                    { 156, "Slovakia" },
                    { 157, "Slovenia" },
                    { 158, "Somalia" },
                    { 159, "South Africa" },
                    { 160, "South Korea" },
                    { 161, "South Sudan" },
                    { 162, "Spain" },
                    { 163, "Sri Lanka" },
                    { 164, "State of Palestine" },
                    { 165, "Sudan" },
                    { 166, "Suriname" },
                    { 167, "Sweden" },
                    { 168, "Switzerland" },
                    { 169, "Syria" },
                    { 170, "Taiwan" },
                    { 171, "Tajikistan" },
                    { 172, "Tanzania" },
                    { 173, "Thailand" },
                    { 174, "The Bahamas" },
                    { 175, "Timor-Leste" },
                    { 176, "Togo" },
                    { 177, "Trinidad and Tobago" },
                    { 178, "Tunisia" },
                    { 179, "Turkey" },
                    { 180, "Turkmenistan" },
                    { 181, "Uganda" },
                    { 182, "Ukraine" },
                    { 183, "United Arab Emirates" },
                    { 184, "United Kingdom" },
                    { 185, "United States" },
                    { 186, "Uruguay" },
                    { 187, "Uzbekistan" },
                    { 188, "Venezuela" },
                    { 189, "Vietnam" },
                    { 190, "Western Sahara" },
                    { 191, "Yemen" },
                    { 192, "Zambia" },
                    { 193, "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Name", "ExpirationDate", "Reduction" },
                values: new object[,]
                {
                    { "BIGTREAT", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.25f },
                    { "FREESHIPPING", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.3f },
                    { "SPOOKY15", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.15f }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Processing" },
                    { 3, "Shipped" },
                    { 4, "Delivered" },
                    { 5, "Returned" },
                    { 6, "Cancelled" },
                    { 7, "On Hold" }
                });

            migrationBuilder.InsertData(
                table: "ShippingMethods",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Regular", 20f },
                    { 2, "Express", 50f },
                    { 3, "Free", 0f }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Star" },
                values: new object[,]
                {
                    { 1, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle", 5 },
                    { 2, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight", 4 },
                    { 3, 1, "Hero Basic mens Round Neck Undershirt", "/Image/Products/3.jpg", "Hero Basic", 4 },
                    { 4, 1, "Romba Men's Summer Text Sleeve Cotton T Shirt", "/Image/Products/4.jpg", "Romba", 5 },
                    { 5, 1, "Andora Mens 33S22M30333 T-Shirt", "/Image/Products/5.jpg", "Andora", 4 },
                    { 6, 1, "CAESAR Mens MensSport T-Shirt With Short Sleeves MensSport T-Shirt With Short Sleeves", "/Image/Products/6.jpg", "CAESAR", 4 },
                    { 7, 1, "Nexus Original Cotton T-Shirt", "/Image/Products/7.jpg", "Nexus", 5 },
                    { 8, 1, "Ravin EG Mens Ravin Chest Printed Cotton T-Shirt For Men S22M048 T-Shirt", "/Image/Products/8.jpg", "Ravin EG", 4 },
                    { 9, 1, "CAESAR Mens Mens Printed Round Neck T-Shirt T-Shirt", "/Image/Products/9.jpg", "CAESAR", 4 },
                    { 10, 1, "adidas Mens Train Essentials Seasonal Logo Training T-Shirt TRAINING T-SHIRTS for Men T-Shirt", "/Image/Products/10.jpg", "adidas", 5 },
                    { 11, 1, "Adidas linear beach-bit short sleeve graphic t-shirt t-shirts for men", "/Image/Products/11.jpg", "adidas", 4 },
                    { 12, 1, "BlackEdition Over size snake T-shirt", "/Image/Products/12.jpg", "Generic", 4 },
                    { 13, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle", 5 },
                    { 14, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight", 4 },
                    { 15, 1, "Hero Basic mens Round Neck Undershirt", "/Image/Products/3.jpg", "Hero Basic", 4 },
                    { 16, 1, "Romba Men's Summer Text Sleeve Cotton T Shirt", "/Image/Products/4.jpg", "Romba", 5 },
                    { 17, 1, "Andora Mens 33S22M30333 T-Shirt", "/Image/Products/5.jpg", "Andora", 4 },
                    { 18, 1, "CAESAR Mens MensSport T-Shirt With Short Sleeves MensSport T-Shirt With Short Sleeves", "/Image/Products/6.jpg", "CAESAR", 4 },
                    { 19, 1, "Nexus Original Cotton T-Shirt", "/Image/Products/7.jpg", "Nexus", 5 },
                    { 20, 1, "Ravin EG Mens Ravin Chest Printed Cotton T-Shirt For Men S22M048 T-Shirt", "/Image/Products/8.jpg", "Ravin EG", 4 },
                    { 21, 1, "CAESAR Mens Mens Printed Round Neck T-Shirt T-Shirt", "/Image/Products/9.jpg", "CAESAR", 4 },
                    { 22, 1, "adidas Mens Train Essentials Seasonal Logo Training T-Shirt TRAINING T-SHIRTS for Men T-Shirt", "/Image/Products/10.jpg", "adidas", 5 },
                    { 23, 1, "Adidas linear beach-bit short sleeve graphic t-shirt t-shirts for men", "/Image/Products/11.jpg", "adidas", 4 },
                    { 24, 1, "BlackEdition Over size snake T-shirt", "/Image/Products/12.jpg", "Generic", 4 },
                    { 25, 1, "American Eagle Men U-0181-2395-604 Super Soft Graphic T-Shirt", "/Image/Products/1.jpg", "American Eagle", 5 },
                    { 26, 1, "Knight Mens Stretch Round Neck T-Shirt Half sleeves Kngh Base Layer Top", "/Image/Products/2.jpg", "Knight", 4 },
                    { 27, 1, "Hero Basic mens Round Neck Undershirt", "/Image/Products/3.jpg", "Hero Basic", 4 },
                    { 28, 1, "Romba Men's Summer Text Sleeve Cotton T Shirt", "/Image/Products/4.jpg", "Romba", 5 },
                    { 29, 1, "Andora Mens 33S22M30333 T-Shirt", "/Image/Products/5.jpg", "Andora", 4 },
                    { 30, 1, "CAESAR Mens MensSport T-Shirt With Short Sleeves MensSport T-Shirt With Short Sleeves", "/Image/Products/6.jpg", "CAESAR", 4 },
                    { 31, 2, "HIGH QUALITY Classic-fit Men's Pants for Gentleman", "/Image/Products/13.jpg", "BLACK TIGER", 5 },
                    { 32, 3, "Mintra CAI Women Shoes", "/Image/Products/14.jpg", "Mintra", 4 },
                    { 33, 4, "STITCH mens Pack of 5 Lycra Ankle Socks", "/Image/Products/15.jpg", "STITCH", 4 },
                    { 34, 5, "SEIKO QUARTZ Metal Band Analg Watch for Men BLUE Dial SUR399P1", "/Image/Products/16.jpg", "SEIKO", 5 },
                    { 35, 6, "Jamila Women Stripped oversized shirt with two pockets", "/Image/Products/17.jpg", "Jamila", 4 },
                    { 36, 7, "Toshiba - Washing Machine - 8kg - Silver - Inverter - 1400rpm - TW-BJ90M4E(SK)", "/Image/Products/18.jpg", "Toshiba - Washing Machine", 4 },
                    { 37, 8, "Nutricook AF357V AIR FRYER 3 VISION 5.7L 1700W Black clear window - International warranty", "/Image/Products/19.jpg", "Nutricook AF357V AIR FRYER", 5 }
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
                    { 1, "/Image/Products/1.jpg", 120f, 1, "AmericanEagle-L-Red", 100 },
                    { 2, "/Image/Products/2.jpg", 100f, 1, "AmericanEagle-XL-Red", 50 },
                    { 3, "/Image/Products/1.jpg", 80f, 1, "AmericanEagle-L-Blue", 20 },
                    { 4, "/Image/Products/2.jpg", 200f, 1, "AmericanEagle-XL-Blue", 0 },
                    { 5, "/Image/Products/1.jpg", 120f, 2, "Knight-L-Red", 200 },
                    { 6, "/Image/Products/2.jpg", 100f, 2, "Knight-XL-Red", 300 },
                    { 7, "/Image/Products/1.jpg", 80f, 2, "Knight-L-Blue", 10 },
                    { 8, "/Image/Products/2.jpg", 200f, 2, "Knight-XL-Blue", 60 },
                    { 9, "/Image/Products/1.jpg", 120f, 3, "AmericanEagle-L-Red", 100 },
                    { 10, "/Image/Products/2.jpg", 100f, 3, "AmericanEagle-XL-Red", 50 },
                    { 11, "/Image/Products/1.jpg", 80f, 3, "AmericanEagle-L-Blue", 20 },
                    { 12, "/Image/Products/2.jpg", 200f, 3, "AmericanEagle-XL-Blue", 0 },
                    { 13, "/Image/Products/1.jpg", 120f, 4, "Knight-L-Red", 200 },
                    { 14, "/Image/Products/2.jpg", 100f, 4, "Knight-XL-Red", 300 },
                    { 15, "/Image/Products/1.jpg", 80f, 4, "Knight-L-Blue", 10 },
                    { 16, "/Image/Products/2.jpg", 200f, 4, "Knight-XL-Blue", 60 },
                    { 17, "/Image/Products/1.jpg", 120f, 5, "AmericanEagle-L-Red", 100 },
                    { 18, "/Image/Products/2.jpg", 100f, 5, "AmericanEagle-XL-Red", 50 },
                    { 19, "/Image/Products/1.jpg", 80f, 5, "AmericanEagle-L-Blue", 20 },
                    { 20, "/Image/Products/2.jpg", 200f, 5, "AmericanEagle-XL-Blue", 0 },
                    { 21, "/Image/Products/1.jpg", 120f, 6, "Knight-L-Red", 200 },
                    { 22, "/Image/Products/2.jpg", 100f, 6, "Knight-XL-Red", 300 },
                    { 23, "/Image/Products/1.jpg", 80f, 6, "Knight-L-Blue", 10 },
                    { 24, "/Image/Products/2.jpg", 200f, 6, "Knight-XL-Blue", 60 },
                    { 25, "/Image/Products/1.jpg", 120f, 7, "AmericanEagle-L-Red", 100 },
                    { 26, "/Image/Products/2.jpg", 100f, 7, "AmericanEagle-XL-Red", 50 },
                    { 27, "/Image/Products/1.jpg", 80f, 7, "AmericanEagle-L-Blue", 20 },
                    { 28, "/Image/Products/2.jpg", 200f, 7, "AmericanEagle-XL-Blue", 0 },
                    { 29, "/Image/Products/1.jpg", 120f, 8, "Knight-L-Red", 200 },
                    { 30, "/Image/Products/2.jpg", 100f, 8, "Knight-XL-Red", 300 },
                    { 31, "/Image/Products/1.jpg", 80f, 8, "Knight-L-Blue", 10 },
                    { 32, "/Image/Products/2.jpg", 200f, 8, "Knight-XL-Blue", 60 },
                    { 33, "/Image/Products/1.jpg", 120f, 9, "AmericanEagle-L-Red", 100 },
                    { 34, "/Image/Products/2.jpg", 100f, 9, "AmericanEagle-XL-Red", 50 },
                    { 35, "/Image/Products/1.jpg", 80f, 9, "AmericanEagle-L-Blue", 20 },
                    { 36, "/Image/Products/2.jpg", 200f, 9, "AmericanEagle-XL-Blue", 0 },
                    { 37, "/Image/Products/1.jpg", 120f, 10, "Knight-L-Red", 200 },
                    { 38, "/Image/Products/2.jpg", 100f, 10, "Knight-XL-Red", 300 },
                    { 39, "/Image/Products/1.jpg", 80f, 10, "Knight-L-Blue", 10 },
                    { 40, "/Image/Products/2.jpg", 200f, 10, "Knight-XL-Blue", 60 },
                    { 41, "/Image/Products/1.jpg", 120f, 11, "AmericanEagle-L-Red", 100 },
                    { 42, "/Image/Products/2.jpg", 100f, 11, "AmericanEagle-XL-Red", 50 },
                    { 43, "/Image/Products/1.jpg", 80f, 11, "AmericanEagle-L-Blue", 20 },
                    { 44, "/Image/Products/2.jpg", 200f, 11, "AmericanEagle-XL-Blue", 0 },
                    { 45, "/Image/Products/1.jpg", 120f, 12, "Knight-L-Red", 200 },
                    { 46, "/Image/Products/2.jpg", 100f, 12, "Knight-XL-Red", 300 },
                    { 47, "/Image/Products/1.jpg", 80f, 12, "Knight-L-Blue", 10 },
                    { 48, "/Image/Products/2.jpg", 200f, 12, "Knight-XL-Blue", 60 },
                    { 49, "/Image/Products/1.jpg", 120f, 13, "AmericanEagle-L-Red", 100 },
                    { 50, "/Image/Products/2.jpg", 100f, 13, "AmericanEagle-XL-Red", 50 },
                    { 51, "/Image/Products/1.jpg", 80f, 13, "AmericanEagle-L-Blue", 20 },
                    { 52, "/Image/Products/2.jpg", 200f, 13, "AmericanEagle-XL-Blue", 0 },
                    { 53, "/Image/Products/1.jpg", 120f, 14, "Knight-L-Red", 200 },
                    { 54, "/Image/Products/2.jpg", 100f, 14, "Knight-XL-Red", 300 },
                    { 55, "/Image/Products/1.jpg", 80f, 14, "Knight-L-Blue", 10 },
                    { 56, "/Image/Products/2.jpg", 200f, 14, "Knight-XL-Blue", 60 },
                    { 57, "/Image/Products/1.jpg", 120f, 15, "AmericanEagle-L-Red", 100 },
                    { 58, "/Image/Products/2.jpg", 100f, 15, "AmericanEagle-XL-Red", 50 },
                    { 59, "/Image/Products/1.jpg", 80f, 15, "AmericanEagle-L-Blue", 20 },
                    { 60, "/Image/Products/2.jpg", 200f, 15, "AmericanEagle-XL-Blue", 0 },
                    { 61, "/Image/Products/1.jpg", 120f, 16, "Knight-L-Red", 200 },
                    { 62, "/Image/Products/2.jpg", 100f, 16, "Knight-XL-Red", 300 },
                    { 63, "/Image/Products/1.jpg", 80f, 16, "Knight-L-Blue", 10 },
                    { 64, "/Image/Products/2.jpg", 200f, 16, "Knight-XL-Blue", 60 },
                    { 65, "/Image/Products/1.jpg", 120f, 17, "AmericanEagle-L-Red", 100 },
                    { 66, "/Image/Products/2.jpg", 100f, 17, "AmericanEagle-XL-Red", 50 },
                    { 67, "/Image/Products/1.jpg", 80f, 17, "AmericanEagle-L-Blue", 20 },
                    { 68, "/Image/Products/2.jpg", 200f, 17, "AmericanEagle-XL-Blue", 0 },
                    { 69, "/Image/Products/1.jpg", 120f, 18, "Knight-L-Red", 200 },
                    { 70, "/Image/Products/2.jpg", 100f, 18, "Knight-XL-Red", 300 },
                    { 71, "/Image/Products/1.jpg", 80f, 18, "Knight-L-Blue", 10 },
                    { 72, "/Image/Products/2.jpg", 200f, 18, "Knight-XL-Blue", 60 },
                    { 73, "/Image/Products/1.jpg", 120f, 19, "AmericanEagle-L-Red", 100 },
                    { 74, "/Image/Products/2.jpg", 100f, 19, "AmericanEagle-XL-Red", 50 },
                    { 75, "/Image/Products/1.jpg", 80f, 19, "AmericanEagle-L-Blue", 20 },
                    { 76, "/Image/Products/2.jpg", 200f, 19, "AmericanEagle-XL-Blue", 0 },
                    { 77, "/Image/Products/1.jpg", 120f, 20, "Knight-L-Red", 200 },
                    { 78, "/Image/Products/2.jpg", 100f, 20, "Knight-XL-Red", 300 },
                    { 79, "/Image/Products/1.jpg", 80f, 20, "Knight-L-Blue", 10 },
                    { 80, "/Image/Products/2.jpg", 200f, 20, "Knight-XL-Blue", 60 },
                    { 81, "/Image/Products/1.jpg", 120f, 21, "AmericanEagle-L-Red", 100 },
                    { 82, "/Image/Products/2.jpg", 100f, 21, "AmericanEagle-XL-Red", 50 },
                    { 83, "/Image/Products/1.jpg", 80f, 21, "AmericanEagle-L-Blue", 20 },
                    { 84, "/Image/Products/2.jpg", 200f, 21, "AmericanEagle-XL-Blue", 0 },
                    { 85, "/Image/Products/1.jpg", 120f, 22, "Knight-L-Red", 200 },
                    { 86, "/Image/Products/2.jpg", 100f, 22, "Knight-XL-Red", 300 },
                    { 87, "/Image/Products/1.jpg", 80f, 22, "Knight-L-Blue", 10 },
                    { 88, "/Image/Products/2.jpg", 200f, 22, "Knight-XL-Blue", 60 },
                    { 89, "/Image/Products/1.jpg", 120f, 23, "AmericanEagle-L-Red", 100 },
                    { 90, "/Image/Products/2.jpg", 100f, 23, "AmericanEagle-XL-Red", 50 },
                    { 91, "/Image/Products/1.jpg", 80f, 23, "AmericanEagle-L-Blue", 20 },
                    { 92, "/Image/Products/2.jpg", 200f, 23, "AmericanEagle-XL-Blue", 0 },
                    { 93, "/Image/Products/1.jpg", 120f, 24, "Knight-L-Red", 200 },
                    { 94, "/Image/Products/2.jpg", 100f, 24, "Knight-XL-Red", 300 },
                    { 95, "/Image/Products/1.jpg", 80f, 24, "Knight-L-Blue", 10 },
                    { 96, "/Image/Products/2.jpg", 200f, 24, "Knight-XL-Blue", 60 },
                    { 97, "/Image/Products/1.jpg", 120f, 25, "AmericanEagle-L-Red", 100 },
                    { 98, "/Image/Products/2.jpg", 100f, 25, "AmericanEagle-XL-Red", 50 },
                    { 99, "/Image/Products/1.jpg", 80f, 25, "AmericanEagle-L-Blue", 20 },
                    { 100, "/Image/Products/2.jpg", 200f, 25, "AmericanEagle-XL-Blue", 0 },
                    { 101, "/Image/Products/1.jpg", 120f, 26, "Knight-L-Red", 200 },
                    { 102, "/Image/Products/2.jpg", 100f, 26, "Knight-XL-Red", 300 },
                    { 103, "/Image/Products/1.jpg", 80f, 26, "Knight-L-Blue", 10 },
                    { 104, "/Image/Products/2.jpg", 200f, 26, "Knight-XL-Blue", 60 },
                    { 105, "/Image/Products/1.jpg", 120f, 27, "AmericanEagle-L-Red", 100 },
                    { 106, "/Image/Products/2.jpg", 100f, 27, "AmericanEagle-XL-Red", 50 },
                    { 107, "/Image/Products/1.jpg", 80f, 27, "AmericanEagle-L-Blue", 20 },
                    { 108, "/Image/Products/2.jpg", 200f, 27, "AmericanEagle-XL-Blue", 0 },
                    { 109, "/Image/Products/1.jpg", 120f, 28, "Knight-L-Red", 200 },
                    { 110, "/Image/Products/2.jpg", 100f, 28, "Knight-XL-Red", 300 },
                    { 111, "/Image/Products/1.jpg", 80f, 28, "Knight-L-Blue", 10 },
                    { 112, "/Image/Products/2.jpg", 200f, 28, "Knight-XL-Blue", 60 },
                    { 113, "/Image/Products/1.jpg", 120f, 29, "AmericanEagle-L-Red", 100 },
                    { 114, "/Image/Products/2.jpg", 100f, 29, "AmericanEagle-XL-Red", 50 },
                    { 115, "/Image/Products/1.jpg", 80f, 29, "AmericanEagle-L-Blue", 20 },
                    { 116, "/Image/Products/2.jpg", 200f, 29, "AmericanEagle-XL-Blue", 0 },
                    { 117, "/Image/Products/1.jpg", 120f, 30, "Knight-L-Red", 200 },
                    { 118, "/Image/Products/2.jpg", 100f, 30, "Knight-XL-Red", 300 },
                    { 119, "/Image/Products/1.jpg", 80f, 30, "Knight-L-Blue", 10 },
                    { 120, "/Image/Products/2.jpg", 200f, 30, "Knight-XL-Blue", 60 }
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
                name: "IX_Addresses_Country_Id",
                table: "Addresses",
                column: "Country_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserProduct_ProductsId",
                table: "ApplicationUserProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_ApplicationUserId",
                table: "CartProducts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_ProductItemId",
                table: "CartProducts",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLines",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_ProductItemId",
                table: "OrderLines",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_PaymentTypeId",
                table: "PaymentMethods",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_UserId",
                table: "PaymentMethods",
                column: "UserId");

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
                name: "IX_ShopOrders_OrderStatusId",
                table: "ShopOrders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrders_ShippingAddressId",
                table: "ShopOrders",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrders_ShippingMethodId",
                table: "ShopOrders",
                column: "ShippingMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrders_UserId",
                table: "ShopOrders",
                column: "UserId");

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
                name: "ApplicationUserProduct");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartProducts");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "ProductConfigurations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ShopOrders");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "ProductItems");

            migrationBuilder.DropTable(
                name: "VariationOptions");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "ShippingMethods");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Variations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

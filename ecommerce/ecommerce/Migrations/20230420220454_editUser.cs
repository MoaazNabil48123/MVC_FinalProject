using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class editUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_Addresses_AspNetUsers_ApplicationUserId",
                table: "user_Addresses");

            migrationBuilder.DropIndex(
                name: "IX_user_Addresses_ApplicationUserId",
                table: "user_Addresses");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "user_Addresses");

            migrationBuilder.AlterColumn<string>(
                name: "User_Id",
                table: "user_Addresses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_user_Addresses_User_Id",
                table: "user_Addresses",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_user_Addresses_AspNetUsers_User_Id",
                table: "user_Addresses",
                column: "User_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_Addresses_AspNetUsers_User_Id",
                table: "user_Addresses");

            migrationBuilder.DropIndex(
                name: "IX_user_Addresses_User_Id",
                table: "user_Addresses");

            migrationBuilder.AlterColumn<int>(
                name: "User_Id",
                table: "user_Addresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "user_Addresses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_user_Addresses_ApplicationUserId",
                table: "user_Addresses",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_Addresses_AspNetUsers_ApplicationUserId",
                table: "user_Addresses",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TheReddit.Migrations
{
    public partial class PostGre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_NickName",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "NickName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NickName",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Users_NickName",
                table: "Users",
                column: "NickName",
                unique: true);
        }
    }
}

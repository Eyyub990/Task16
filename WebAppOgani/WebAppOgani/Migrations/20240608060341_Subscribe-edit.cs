using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppOgani.Migrations
{
    /// <inheritdoc />
    public partial class Subscribeedit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "SubscribePost",
                newName: "SubscribePosts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscribePosts",
                table: "SubscribePosts",
                column: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscribePosts",
                table: "SubscribePosts");

            migrationBuilder.RenameTable(
                name: "SubscribePosts",
                newName: "SubscribePost");
        }
    }
}

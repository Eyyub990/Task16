using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppOgani.Migrations
{
    /// <inheritdoc />
    public partial class SubscribePosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubscribePost",
                columns: table => new
                {
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubscribePost");
        }
    }
}

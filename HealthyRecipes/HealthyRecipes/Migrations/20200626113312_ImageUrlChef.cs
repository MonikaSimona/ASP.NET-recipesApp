using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyRecipes.Migrations
{
    public partial class ImageUrlChef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Chef",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Chef");
        }
    }
}

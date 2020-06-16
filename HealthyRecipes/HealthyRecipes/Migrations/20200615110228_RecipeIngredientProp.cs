using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyRecipes.Migrations
{
    public partial class RecipeIngredientProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaloriesPerRecipe",
                table: "RecipeIngredient",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ProteinsPerRecipe",
                table: "RecipeIngredient",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaloriesPerRecipe",
                table: "RecipeIngredient");

            migrationBuilder.DropColumn(
                name: "ProteinsPerRecipe",
                table: "RecipeIngredient");
        }
    }
}

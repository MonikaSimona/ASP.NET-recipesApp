using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyRecipes.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaloriesPerRecipe",
                table: "RecipeIngredient");

            migrationBuilder.DropColumn(
                name: "IngredientQuantity",
                table: "RecipeIngredient");

            migrationBuilder.DropColumn(
                name: "ProteinsPerRecipe",
                table: "RecipeIngredient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaloriesPerRecipe",
                table: "RecipeIngredient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IngredientQuantity",
                table: "RecipeIngredient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ProteinsPerRecipe",
                table: "RecipeIngredient",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}

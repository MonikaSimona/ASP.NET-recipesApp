using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyRecipes.Migrations
{
    public partial class ChangedProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VitaminsPerItem",
                table: "Ingredient");

            migrationBuilder.AlterColumn<double>(
                name: "ProteinsPerRecipe",
                table: "RecipeIngredient",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "ProteinsPerItem",
                table: "Ingredient",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "SugarPerItem",
                table: "Ingredient",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SugarPerItem",
                table: "Ingredient");

            migrationBuilder.AlterColumn<int>(
                name: "ProteinsPerRecipe",
                table: "RecipeIngredient",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "ProteinsPerItem",
                table: "Ingredient",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<int>(
                name: "VitaminsPerItem",
                table: "Ingredient",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

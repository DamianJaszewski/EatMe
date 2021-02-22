using Microsoft.EntityFrameworkCore.Migrations;

namespace EatMeApp.Data.Migrations
{
    public partial class MeasureIngredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IgredientId",
                table: "IngredientLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "IngredientLists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeasureId",
                table: "IngredientLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Measure",
                columns: table => new
                {
                    MeasureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measure", x => x.MeasureId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientLists_IngredientId",
                table: "IngredientLists",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientLists_MeasureId",
                table: "IngredientLists",
                column: "MeasureId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientLists_Ingredient_IngredientId",
                table: "IngredientLists",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "IngredientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientLists_Measure_MeasureId",
                table: "IngredientLists",
                column: "MeasureId",
                principalTable: "Measure",
                principalColumn: "MeasureId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientLists_Ingredient_IngredientId",
                table: "IngredientLists");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientLists_Measure_MeasureId",
                table: "IngredientLists");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Measure");

            migrationBuilder.DropIndex(
                name: "IX_IngredientLists_IngredientId",
                table: "IngredientLists");

            migrationBuilder.DropIndex(
                name: "IX_IngredientLists_MeasureId",
                table: "IngredientLists");

            migrationBuilder.DropColumn(
                name: "IgredientId",
                table: "IngredientLists");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "IngredientLists");

            migrationBuilder.DropColumn(
                name: "MeasureId",
                table: "IngredientLists");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Tacos.Migrations
{
    public partial class addComposition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Tacos_TacosId",
                table: "Ingredient");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_TacosId",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "TacosId",
                table: "Ingredient");

            migrationBuilder.CreateTable(
                name: "Composition",
                columns: table => new
                {
                    TacosId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composition", x => new { x.IngredientId, x.TacosId });
                    table.ForeignKey(
                        name: "FK_Composition_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Composition_Tacos_TacosId",
                        column: x => x.TacosId,
                        principalTable: "Tacos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Composition_TacosId",
                table: "Composition",
                column: "TacosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Composition");

            migrationBuilder.AddColumn<int>(
                name: "TacosId",
                table: "Ingredient",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_TacosId",
                table: "Ingredient",
                column: "TacosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Tacos_TacosId",
                table: "Ingredient",
                column: "TacosId",
                principalTable: "Tacos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

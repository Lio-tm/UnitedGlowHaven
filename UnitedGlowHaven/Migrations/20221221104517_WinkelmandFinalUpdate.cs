using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitedGlowHaven.Migrations
{
    public partial class WinkelmandFinalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductMaat");

            migrationBuilder.AddColumn<int>(
                name: "MaatId",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_MaatId",
                table: "Product",
                column: "MaatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Maat_MaatId",
                table: "Product",
                column: "MaatId",
                principalTable: "Maat",
                principalColumn: "MaatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Maat_MaatId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_MaatId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "MaatId",
                table: "Product");

            migrationBuilder.CreateTable(
                name: "ProductMaat",
                columns: table => new
                {
                    ProductMaatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aantal = table.Column<int>(type: "int", nullable: false),
                    MaatId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaat", x => x.ProductMaatId);
                    table.ForeignKey(
                        name: "FK_ProductMaat_Maat_MaatId",
                        column: x => x.MaatId,
                        principalTable: "Maat",
                        principalColumn: "MaatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMaat_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaat_MaatId",
                table: "ProductMaat",
                column: "MaatId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaat_ProductId",
                table: "ProductMaat",
                column: "ProductId");
        }
    }
}

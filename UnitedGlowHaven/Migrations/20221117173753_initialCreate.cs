using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitedGlowHaven.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    CategorieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.CategorieId);
                });

            migrationBuilder.CreateTable(
                name: "Klant",
                columns: table => new
                {
                    KlantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(nullable: false),
                    Achternaam = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klant", x => x.KlantId);
                });

            migrationBuilder.CreateTable(
                name: "Kleur",
                columns: table => new
                {
                    KleurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kleur", x => x.KleurId);
                });

            migrationBuilder.CreateTable(
                name: "Maat",
                columns: table => new
                {
                    MaatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maat", x => x.MaatId);
                });

            migrationBuilder.CreateTable(
                name: "Winkelmand",
                columns: table => new
                {
                    WinkelmandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Afgerekend = table.Column<bool>(nullable: false),
                    KlantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Winkelmand", x => x.WinkelmandId);
                    table.ForeignKey(
                        name: "FK_Winkelmand_Klant_KlantId",
                        column: x => x.KlantId,
                        principalTable: "Klant",
                        principalColumn: "KlantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Beschrijving = table.Column<string>(nullable: true),
                    Prijs = table.Column<decimal>(nullable: false),
                    Afbeelding = table.Column<string>(nullable: false),
                    ProductNummer = table.Column<string>(nullable: false),
                    KleurId = table.Column<int>(nullable: false),
                    CategorieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Categorie_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categorie",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Kleur_KleurId",
                        column: x => x.KleurId,
                        principalTable: "Kleur",
                        principalColumn: "KleurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaat",
                columns: table => new
                {
                    ProductMaatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    MaatId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "WinkelmandProduct",
                columns: table => new
                {
                    WinkelmandProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinkelmandId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinkelmandProduct", x => x.WinkelmandProductId);
                    table.ForeignKey(
                        name: "FK_WinkelmandProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WinkelmandProduct_Winkelmand_WinkelmandId",
                        column: x => x.WinkelmandId,
                        principalTable: "Winkelmand",
                        principalColumn: "WinkelmandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategorieId",
                table: "Product",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_KleurId",
                table: "Product",
                column: "KleurId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaat_MaatId",
                table: "ProductMaat",
                column: "MaatId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaat_ProductId",
                table: "ProductMaat",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Winkelmand_KlantId",
                table: "Winkelmand",
                column: "KlantId");

            migrationBuilder.CreateIndex(
                name: "IX_WinkelmandProduct_ProductId",
                table: "WinkelmandProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WinkelmandProduct_WinkelmandId",
                table: "WinkelmandProduct",
                column: "WinkelmandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductMaat");

            migrationBuilder.DropTable(
                name: "WinkelmandProduct");

            migrationBuilder.DropTable(
                name: "Maat");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Winkelmand");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Kleur");

            migrationBuilder.DropTable(
                name: "Klant");
        }
    }
}

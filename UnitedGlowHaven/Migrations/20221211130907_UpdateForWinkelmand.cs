using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitedGlowHaven.Migrations
{
    public partial class UpdateForWinkelmand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Winkelmand_Klant_KlantId",
                table: "Winkelmand");

            migrationBuilder.DropTable(
                name: "Klant");

            migrationBuilder.DropIndex(
                name: "IX_Winkelmand_KlantId",
                table: "Winkelmand");

            migrationBuilder.DropColumn(
                name: "KlantId",
                table: "Winkelmand");

            migrationBuilder.AddColumn<int>(
                name: "Aantal",
                table: "WinkelmandProduct",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Prijs",
                table: "WinkelmandProduct",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "CustomUserId",
                table: "Winkelmand",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Totaal",
                table: "Winkelmand",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Aantal",
                table: "ProductMaat",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Winkelmand_CustomUserId",
                table: "Winkelmand",
                column: "CustomUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Winkelmand_AspNetUsers_CustomUserId",
                table: "Winkelmand",
                column: "CustomUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Winkelmand_AspNetUsers_CustomUserId",
                table: "Winkelmand");

            migrationBuilder.DropIndex(
                name: "IX_Winkelmand_CustomUserId",
                table: "Winkelmand");

            migrationBuilder.DropColumn(
                name: "Aantal",
                table: "WinkelmandProduct");

            migrationBuilder.DropColumn(
                name: "Prijs",
                table: "WinkelmandProduct");

            migrationBuilder.DropColumn(
                name: "CustomUserId",
                table: "Winkelmand");

            migrationBuilder.DropColumn(
                name: "Totaal",
                table: "Winkelmand");

            migrationBuilder.DropColumn(
                name: "Aantal",
                table: "ProductMaat");

            migrationBuilder.AddColumn<int>(
                name: "KlantId",
                table: "Winkelmand",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Klant",
                columns: table => new
                {
                    KlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Achternaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klant", x => x.KlantId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Winkelmand_KlantId",
                table: "Winkelmand",
                column: "KlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Winkelmand_Klant_KlantId",
                table: "Winkelmand",
                column: "KlantId",
                principalTable: "Klant",
                principalColumn: "KlantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

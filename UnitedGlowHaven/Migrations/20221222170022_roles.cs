using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitedGlowHaven.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Postocde",
                table: "CustomUser");

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "CustomUser",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "CustomUser");

            migrationBuilder.AddColumn<string>(
                name: "Postocde",
                table: "CustomUser",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

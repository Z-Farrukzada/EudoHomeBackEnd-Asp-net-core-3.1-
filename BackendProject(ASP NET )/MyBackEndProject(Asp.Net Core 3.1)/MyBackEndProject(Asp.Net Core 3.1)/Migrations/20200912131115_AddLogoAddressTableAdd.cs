using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Migrations
{
    public partial class AddLogoAddressTableAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Logos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EudoHomeAdress",
                table: "Logos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EudoHomePlaceCountry",
                table: "Logos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Logos");

            migrationBuilder.DropColumn(
                name: "EudoHomeAdress",
                table: "Logos");

            migrationBuilder.DropColumn(
                name: "EudoHomePlaceCountry",
                table: "Logos");
        }
    }
}

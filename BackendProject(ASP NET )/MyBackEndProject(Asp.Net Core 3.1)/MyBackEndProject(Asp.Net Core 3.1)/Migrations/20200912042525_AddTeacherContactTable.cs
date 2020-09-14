using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Migrations
{
    public partial class AddTeacherContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pinterest",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skype",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Pinterest",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Skype",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "Teachers");
        }
    }
}

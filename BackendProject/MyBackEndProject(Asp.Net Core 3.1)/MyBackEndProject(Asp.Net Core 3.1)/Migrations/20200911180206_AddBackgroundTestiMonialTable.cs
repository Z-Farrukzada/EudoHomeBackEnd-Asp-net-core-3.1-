using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Migrations
{
    public partial class AddBackgroundTestiMonialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgroundImage",
                table: "Testimonials",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundImage",
                table: "Testimonials");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Migrations
{
    public partial class AddCourseTableChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutCourse",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Certification",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HowDoApply",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutCourse",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Certification",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "HowDoApply",
                table: "Courses");
        }
    }
}

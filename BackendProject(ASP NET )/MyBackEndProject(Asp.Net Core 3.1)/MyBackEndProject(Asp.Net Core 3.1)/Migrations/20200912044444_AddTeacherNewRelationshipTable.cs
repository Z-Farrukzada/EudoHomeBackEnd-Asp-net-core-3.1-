using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Migrations
{
    public partial class AddTeacherNewRelationshipTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactTel",
                table: "Teachers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamLeader = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Development = table.Column<string>(nullable: true),
                    Design = table.Column<string>(nullable: true),
                    Innovation = table.Column<string>(nullable: true),
                    Communication = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills",
                column: "TeacherId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ContactTel",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

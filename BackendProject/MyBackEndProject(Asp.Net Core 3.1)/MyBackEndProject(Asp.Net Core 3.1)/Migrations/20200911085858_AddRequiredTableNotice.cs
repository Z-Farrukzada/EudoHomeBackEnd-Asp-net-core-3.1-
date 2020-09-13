using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Migrations
{
    public partial class AddRequiredTableNotice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NoticeTime",
                table: "NoticeBoards",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NoticeTime",
                table: "NoticeBoards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}

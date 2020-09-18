using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Migrations
{
    public partial class AddNewEventChngeColumName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewManagmentEvents_NewEvents_NewEventId",
                table: "NewManagmentEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_NewManagmentEvents_NewManagmentBoards_NewManagmentBoardId",
                table: "NewManagmentEvents");

            migrationBuilder.AlterColumn<int>(
                name: "NewManagmentBoardId",
                table: "NewManagmentEvents",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NewEventId",
                table: "NewManagmentEvents",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NewManagmentEvents_NewEvents_NewEventId",
                table: "NewManagmentEvents",
                column: "NewEventId",
                principalTable: "NewEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewManagmentEvents_NewManagmentBoards_NewManagmentBoardId",
                table: "NewManagmentEvents",
                column: "NewManagmentBoardId",
                principalTable: "NewManagmentBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewManagmentEvents_NewEvents_NewEventId",
                table: "NewManagmentEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_NewManagmentEvents_NewManagmentBoards_NewManagmentBoardId",
                table: "NewManagmentEvents");

            migrationBuilder.AlterColumn<int>(
                name: "NewManagmentBoardId",
                table: "NewManagmentEvents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "NewEventId",
                table: "NewManagmentEvents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_NewManagmentEvents_NewEvents_NewEventId",
                table: "NewManagmentEvents",
                column: "NewEventId",
                principalTable: "NewEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewManagmentEvents_NewManagmentBoards_NewManagmentBoardId",
                table: "NewManagmentEvents",
                column: "NewManagmentBoardId",
                principalTable: "NewManagmentBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

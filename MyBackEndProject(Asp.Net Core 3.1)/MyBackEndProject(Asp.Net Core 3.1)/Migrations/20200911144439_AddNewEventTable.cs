using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Migrations
{
    public partial class AddNewEventTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    EventTime = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    EventPlace = table.Column<string>(nullable: true),
                    EventStart = table.Column<string>(nullable: true),
                    EventFinish = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewManagmentBoards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewManagmentBoards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewManagmentEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(nullable: false),
                    NewEventId = table.Column<int>(nullable: true),
                    ManagmentBoardId = table.Column<int>(nullable: false),
                    NewManagmentBoardId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewManagmentEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewManagmentEvents_NewEvents_NewEventId",
                        column: x => x.NewEventId,
                        principalTable: "NewEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewManagmentEvents_NewManagmentBoards_NewManagmentBoardId",
                        column: x => x.NewManagmentBoardId,
                        principalTable: "NewManagmentBoards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewManagmentEvents_NewEventId",
                table: "NewManagmentEvents",
                column: "NewEventId");

            migrationBuilder.CreateIndex(
                name: "IX_NewManagmentEvents_NewManagmentBoardId",
                table: "NewManagmentEvents",
                column: "NewManagmentBoardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewManagmentEvents");

            migrationBuilder.DropTable(
                name: "NewEvents");

            migrationBuilder.DropTable(
                name: "NewManagmentBoards");
        }
    }
}

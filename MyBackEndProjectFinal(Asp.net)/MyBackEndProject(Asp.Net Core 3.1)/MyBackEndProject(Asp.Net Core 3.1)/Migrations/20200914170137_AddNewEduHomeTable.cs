﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBackEndProject_Asp.Net_Core_3._1_.Migrations
{
    public partial class AddNewEduHomeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WelcomeEduHomes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelcomeEduHomes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WelcomeEduHomes");
        }
    }
}

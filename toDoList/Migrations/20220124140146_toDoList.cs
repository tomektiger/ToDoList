using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace toDoList.Migrations
{
    public partial class toDoList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    ID = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Task = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}

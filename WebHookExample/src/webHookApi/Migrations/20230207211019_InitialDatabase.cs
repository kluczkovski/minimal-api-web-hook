using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webHookApi.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PayLoad",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Action = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayLoad", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Issue",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PayLoadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "varchar(250)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issue", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Issue_PayLoad_PayLoadId",
                        column: x => x.PayLoadId,
                        principalTable: "PayLoad",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Repository",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PayLoadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repository", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Repository_PayLoad_PayLoadId",
                        column: x => x.PayLoadId,
                        principalTable: "PayLoad",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sender",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PayLoadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Login = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sender", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Sender_PayLoad_PayLoadId",
                        column: x => x.PayLoadId,
                        principalTable: "PayLoad",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Issue_PayLoadId",
                table: "Issue",
                column: "PayLoadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Repository_PayLoadId",
                table: "Repository",
                column: "PayLoadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sender_PayLoadId",
                table: "Sender",
                column: "PayLoadId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issue");

            migrationBuilder.DropTable(
                name: "Repository");

            migrationBuilder.DropTable(
                name: "Sender");

            migrationBuilder.DropTable(
                name: "PayLoad");
        }
    }
}

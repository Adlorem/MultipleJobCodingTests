using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BIRBlazorTest.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Vat = table.Column<string>(type: "TEXT", nullable: false),
                    Regon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErrorModel",
                columns: table => new
                {
                    ErrorCode = table.Column<string>(type: "TEXT", nullable: false),
                    ErrorMessagePl = table.Column<string>(type: "TEXT", nullable: false),
                    ErrorMessageEn = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyModelId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorModel", x => x.ErrorCode);
                    table.ForeignKey(
                        name: "FK_ErrorModel_Company_CompanyModelId",
                        column: x => x.CompanyModelId,
                        principalTable: "Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ErrorModel_CompanyModelId",
                table: "ErrorModel",
                column: "CompanyModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErrorModel");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalBankExampleCore.Migrations
{
    public partial class initialdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiesDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Balance = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    IsBlock = table.Column<bool>(type: "bit", nullable: false),
                    LastTransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiesDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BankAccounts_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreateDate", "FirstName", "LastModifiesDate", "LastName", "Password", "UserName" },
                values: new object[] { 1, new DateTime(2023, 1, 14, 9, 47, 27, 220, DateTimeKind.Local).AddTicks(1440), "maryam", new DateTime(2023, 1, 14, 9, 47, 27, 220, DateTimeKind.Local).AddTicks(1478), "akbari", "mm", "mm" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreateDate", "FirstName", "LastModifiesDate", "LastName", "Password", "UserName" },
                values: new object[] { 2, new DateTime(2023, 1, 14, 9, 47, 27, 220, DateTimeKind.Local).AddTicks(1481), "zeynab", new DateTime(2023, 1, 14, 9, 47, 27, 220, DateTimeKind.Local).AddTicks(1483), "shabanpour", "zz", "zz" });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_UserID",
                table: "BankAccounts",
                column: "UserID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

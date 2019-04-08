using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AAA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BossId",
                table: "Caretakers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Caretakers",
                columns: new[] { "CaretakerId", "BossId", "Email", "EmployDate", "Name" },
                values: new object[] { 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jerrry" });

            migrationBuilder.CreateIndex(
                name: "IX_Caretakers_BossId",
                table: "Caretakers",
                column: "BossId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caretakers_Caretakers_BossId",
                table: "Caretakers",
                column: "BossId",
                principalTable: "Caretakers",
                principalColumn: "CaretakerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caretakers_Caretakers_BossId",
                table: "Caretakers");

            migrationBuilder.DropIndex(
                name: "IX_Caretakers_BossId",
                table: "Caretakers");

            migrationBuilder.DeleteData(
                table: "Caretakers",
                keyColumn: "CaretakerId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "BossId",
                table: "Caretakers");
        }
    }
}

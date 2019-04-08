using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AAA2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Caretakers",
                keyColumn: "CaretakerId",
                keyValue: 2,
                column: "Name",
                value: "Jerry");

            migrationBuilder.InsertData(
                table: "Caretakers",
                columns: new[] { "CaretakerId", "BossId", "Email", "EmployDate", "Name" },
                values: new object[,]
                {
                    { 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jon" },
                    { 4, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Remus" },
                    { 5, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marius" },
                    { 6, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Artem" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Caretakers",
                keyColumn: "CaretakerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Caretakers",
                keyColumn: "CaretakerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Caretakers",
                keyColumn: "CaretakerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Caretakers",
                keyColumn: "CaretakerId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Caretakers",
                keyColumn: "CaretakerId",
                keyValue: 2,
                column: "Name",
                value: "Jerrry");
        }
    }
}

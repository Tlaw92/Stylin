using Microsoft.EntityFrameworkCore.Migrations;

namespace Stylin.Migrations
{
    public partial class PhoneNumber2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b2b72e0-f153-44e1-b284-2c66973efedd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c04ab10-6f0b-489f-941d-a7a9de41aa4a");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Subscriber",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9cac62e9-c3dd-40a6-90e9-7200dfe7d18e", "7301dc24-777e-48e5-a2f1-1212f5b88b11", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "955a89b7-2cad-402b-988d-3fba56359a29", "a176f6d6-8048-48b0-93c1-cf1c3706d40e", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "955a89b7-2cad-402b-988d-3fba56359a29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cac62e9-c3dd-40a6-90e9-7200dfe7d18e");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Subscriber");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b2b72e0-f153-44e1-b284-2c66973efedd", "b7703525-de6f-42fc-9f2d-de22c821b126", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c04ab10-6f0b-489f-941d-a7a9de41aa4a", "223296b0-82bf-4e78-9570-5229313ccacf", "Employee", "EMPLOYEE" });
        }
    }
}

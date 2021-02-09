using Microsoft.EntityFrameworkCore.Migrations;

namespace Stylin.Migrations
{
    public partial class PhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a149a99-9c3f-424d-a71b-b67d21f2874e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ee0ce9a-5168-4ad5-841d-d45645d548cb");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a149a99-9c3f-424d-a71b-b67d21f2874e", "de39d739-c159-47f6-b878-60c015a86576", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ee0ce9a-5168-4ad5-841d-d45645d548cb", "639eed39-ac69-4d13-8b65-ce94193dbb48", "Employee", "EMPLOYEE" });
        }
    }
}

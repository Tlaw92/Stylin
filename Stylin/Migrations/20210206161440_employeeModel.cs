using Microsoft.EntityFrameworkCore.Migrations;

namespace Stylin.Migrations
{
    public partial class employeeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d0724bd-fd38-4358-9c30-2aec2ff543b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5aed5c8e-938f-4642-a6fa-df87e365890e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd809331-d51b-412c-a1bb-1111d565dcfa", "7bab07dc-2e33-4f10-993b-8cc2f6f2462e", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee378d53-6675-46de-be65-4be0b8cd0d2e", "f834739a-042e-4f77-91ba-fb070241ff9a", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee378d53-6675-46de-be65-4be0b8cd0d2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd809331-d51b-412c-a1bb-1111d565dcfa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5aed5c8e-938f-4642-a6fa-df87e365890e", "b1d0dbcc-84e7-457e-aa4c-3ebe4f62ea02", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d0724bd-fd38-4358-9c30-2aec2ff543b9", "464cd7b8-f858-44ba-825a-6ef3bb094bed", "Employee", "EMPLOYEE" });
        }
    }
}

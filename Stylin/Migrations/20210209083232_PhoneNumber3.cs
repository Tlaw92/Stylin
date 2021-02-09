using Microsoft.EntityFrameworkCore.Migrations;

namespace Stylin.Migrations
{
    public partial class PhoneNumber3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "955a89b7-2cad-402b-988d-3fba56359a29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cac62e9-c3dd-40a6-90e9-7200dfe7d18e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c66f3ffa-9346-447c-9d39-bd14893e7a6c", "74d72751-7bf5-4be5-8b1c-6d0934426ed6", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66fb91ce-b895-4fdb-8d15-e1e8339f5c98", "e4a466dc-3bed-4499-8be7-71c970903416", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66fb91ce-b895-4fdb-8d15-e1e8339f5c98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c66f3ffa-9346-447c-9d39-bd14893e7a6c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9cac62e9-c3dd-40a6-90e9-7200dfe7d18e", "7301dc24-777e-48e5-a2f1-1212f5b88b11", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "955a89b7-2cad-402b-988d-3fba56359a29", "a176f6d6-8048-48b0-93c1-cf1c3706d40e", "Employee", "EMPLOYEE" });
        }
    }
}

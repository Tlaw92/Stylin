using Microsoft.EntityFrameworkCore.Migrations;

namespace Stylin.Data.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4362c365-9f28-46cd-8395-489862e2b802");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e5bb021-7d2a-4cd7-8661-5895a9cba897", "d3cb0726-4f86-4b06-8d47-1c8a542ebd2e", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c665eab3-0337-4e0d-82a9-fa71d9ffc5a9", "e24cf82e-1400-4a68-8e17-3add2acbfc5d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e5bb021-7d2a-4cd7-8661-5895a9cba897");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c665eab3-0337-4e0d-82a9-fa71d9ffc5a9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4362c365-9f28-46cd-8395-489862e2b802", "d416ee6d-5806-445e-a33b-4f917383fb7b", "Subscriber", "SUBSCRIBER" });
        }
    }
}

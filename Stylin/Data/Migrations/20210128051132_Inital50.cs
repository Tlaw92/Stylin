using Microsoft.EntityFrameworkCore.Migrations;

namespace Stylin.Data.Migrations
{
    public partial class Inital50 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8005c0b2-19de-4355-81a1-285133efd676", "de7470b5-86d1-4033-8c4c-c556123b7874", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7d357fe-9734-43bb-b1de-3333bf76865e", "b0599561-577a-43ed-8576-2ef472f3f0d4", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8005c0b2-19de-4355-81a1-285133efd676");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7d357fe-9734-43bb-b1de-3333bf76865e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e5bb021-7d2a-4cd7-8661-5895a9cba897", "d3cb0726-4f86-4b06-8d47-1c8a542ebd2e", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c665eab3-0337-4e0d-82a9-fa71d9ffc5a9", "e24cf82e-1400-4a68-8e17-3add2acbfc5d", "Employee", "EMPLOYEE" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Stylin.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94939e4a-c33c-4f82-bda1-cd9e0b29d418");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef86a42b-e5fd-4ceb-bcd6-7217a3cee5e3");

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryFreq",
                table: "Subscriber",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5ab99cc-e474-4d5c-b9a2-42b3a4b57440", "f2bddb2f-0073-4b83-ac02-05b7922de215", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b6da282-0a8b-4503-b31e-ea4388cdb7c9", "a9e2e423-9353-41fd-b765-fea40a80d8d7", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b6da282-0a8b-4503-b31e-ea4388cdb7c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5ab99cc-e474-4d5c-b9a2-42b3a4b57440");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryFreq",
                table: "Subscriber",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef86a42b-e5fd-4ceb-bcd6-7217a3cee5e3", "ef1c2ed0-c375-4d57-835a-0f2682264888", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94939e4a-c33c-4f82-bda1-cd9e0b29d418", "aaf7c4db-277b-4c76-96df-37b069fa7661", "Employee", "EMPLOYEE" });
        }
    }
}

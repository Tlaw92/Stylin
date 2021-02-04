using Microsoft.EntityFrameworkCore.Migrations;

namespace Stylin.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d70088a-07f5-4820-ad9a-c614dab973b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e29c2d0d-124b-45dc-a8ca-eab449153086");

            migrationBuilder.AddColumn<int>(
                name: "DeliveryFreq",
                table: "Subscriber",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PackagePrice",
                table: "Subscriber",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef86a42b-e5fd-4ceb-bcd6-7217a3cee5e3", "ef1c2ed0-c375-4d57-835a-0f2682264888", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94939e4a-c33c-4f82-bda1-cd9e0b29d418", "aaf7c4db-277b-4c76-96df-37b069fa7661", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94939e4a-c33c-4f82-bda1-cd9e0b29d418");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef86a42b-e5fd-4ceb-bcd6-7217a3cee5e3");

            migrationBuilder.DropColumn(
                name: "DeliveryFreq",
                table: "Subscriber");

            migrationBuilder.DropColumn(
                name: "PackagePrice",
                table: "Subscriber");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d70088a-07f5-4820-ad9a-c614dab973b7", "eb4e128b-ccaa-4941-9a9a-0f953c91ed46", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e29c2d0d-124b-45dc-a8ca-eab449153086", "736d0a11-ade4-49e6-807b-1fcc941b6adc", "Employee", "EMPLOYEE" });
        }
    }
}

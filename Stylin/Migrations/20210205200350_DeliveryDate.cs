using Microsoft.EntityFrameworkCore.Migrations;

namespace Stylin.Migrations
{
    public partial class DeliveryDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b6da282-0a8b-4503-b31e-ea4388cdb7c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5ab99cc-e474-4d5c-b9a2-42b3a4b57440");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryDate",
                table: "Subscriber",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5aed5c8e-938f-4642-a6fa-df87e365890e", "b1d0dbcc-84e7-457e-aa4c-3ebe4f62ea02", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d0724bd-fd38-4358-9c30-2aec2ff543b9", "464cd7b8-f858-44ba-825a-6ef3bb094bed", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d0724bd-fd38-4358-9c30-2aec2ff543b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5aed5c8e-938f-4642-a6fa-df87e365890e");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Subscriber");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5ab99cc-e474-4d5c-b9a2-42b3a4b57440", "f2bddb2f-0073-4b83-ac02-05b7922de215", "Subscriber", "SUBSCRIBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b6da282-0a8b-4503-b31e-ea4388cdb7c9", "a9e2e423-9353-41fd-b765-fea40a80d8d7", "Employee", "EMPLOYEE" });
        }
    }
}

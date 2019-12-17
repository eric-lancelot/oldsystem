using Microsoft.EntityFrameworkCore.Migrations;

namespace v1jobportal.Migrations
{
    public partial class revertAllToPrevious : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d2b692c-b816-48d6-9882-855babe62242");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28d52bbc-f1c7-4019-82cd-8f6b115f7a75");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93647892-215e-4faa-9639-376978628cde", "2b5ccddc-2b04-46dd-a874-59901fd2a039", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "617f72ff-6ef3-4b8e-9c61-2ecbc023b139", "09a3e2be-dc7c-4acc-93a6-d8a5681ed7a8", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "617f72ff-6ef3-4b8e-9c61-2ecbc023b139");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93647892-215e-4faa-9639-376978628cde");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28d52bbc-f1c7-4019-82cd-8f6b115f7a75", "8a246c67-acd8-4d0f-b368-f4b45b4c91f5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d2b692c-b816-48d6-9882-855babe62242", "68d8b253-6048-4959-96b0-fd7b4dff36af", "Admin", "ADMIN" });
        }
    }
}

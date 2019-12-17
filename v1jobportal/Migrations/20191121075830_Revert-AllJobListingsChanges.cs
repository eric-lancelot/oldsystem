using Microsoft.EntityFrameworkCore.Migrations;

namespace v1jobportal.Migrations
{
    public partial class RevertAllJobListingsChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "934b26f3-606c-428f-8cf3-3ae6d1ca358a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9ab140d-fd9f-42cc-9dd0-af64f3b70849");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d86d2a6-b070-45e3-b1eb-6e2cc759aaa5", "d12cff91-00d7-49be-831c-f6196be3d9ec", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e68d88b-5c1d-4718-a2b1-676c3059f182", "a0e29302-46e1-451f-bd0a-3a4122529c2c", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d86d2a6-b070-45e3-b1eb-6e2cc759aaa5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e68d88b-5c1d-4718-a2b1-676c3059f182");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9ab140d-fd9f-42cc-9dd0-af64f3b70849", "7f20f3b1-bf20-496c-9b69-a9e1eba913f1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "934b26f3-606c-428f-8cf3-3ae6d1ca358a", "9b4f7ec5-ff5e-4cd6-99d8-751f0b6ea6c8", "Admin", "ADMIN" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace v1jobportal.Migrations
{
    public partial class UpdateNamesApplicantBioData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d86d2a6-b070-45e3-b1eb-6e2cc759aaa5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e68d88b-5c1d-4718-a2b1-676c3059f182");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "ApplicantBioData");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "ApplicantBioData");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28d52bbc-f1c7-4019-82cd-8f6b115f7a75", "8a246c67-acd8-4d0f-b368-f4b45b4c91f5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d2b692c-b816-48d6-9882-855babe62242", "68d8b253-6048-4959-96b0-fd7b4dff36af", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d2b692c-b816-48d6-9882-855babe62242");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28d52bbc-f1c7-4019-82cd-8f6b115f7a75");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "ApplicantBioData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "ApplicantBioData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d86d2a6-b070-45e3-b1eb-6e2cc759aaa5", "d12cff91-00d7-49be-831c-f6196be3d9ec", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e68d88b-5c1d-4718-a2b1-676c3059f182", "a0e29302-46e1-451f-bd0a-3a4122529c2c", "Admin", "ADMIN" });
        }
    }
}

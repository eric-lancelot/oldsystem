using Microsoft.EntityFrameworkCore.Migrations;

namespace v1jobportal.Migrations
{
    public partial class JobIdAndEmpId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c88b8a32-7dde-498f-a9e6-1d78433f8605");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbbf51f6-a6c0-44ae-b3c7-7f51f3260d7c");

            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "ApplicantBioData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "ApplicantBioData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a349c983-06c9-46fd-abd6-3482f52ad796", "d9caa6c3-2d9f-4aeb-8177-8eb8af39270a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bec50c2d-3c4e-4a06-a87f-b3265ca16db6", "d5aaf236-e9c1-4118-b6b1-07b198537376", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a349c983-06c9-46fd-abd6-3482f52ad796");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bec50c2d-3c4e-4a06-a87f-b3265ca16db6");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "ApplicantBioData");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "ApplicantBioData");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbbf51f6-a6c0-44ae-b3c7-7f51f3260d7c", "7bdac29e-eb54-4bfb-a3b8-9e4fceb380be", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c88b8a32-7dde-498f-a9e6-1d78433f8605", "edad20c3-952b-44fe-918d-e9b326d0cbc9", "Admin", "ADMIN" });
        }
    }
}

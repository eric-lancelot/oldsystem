using Microsoft.EntityFrameworkCore.Migrations;

namespace v1jobportal.Migrations
{
    public partial class changeAllJobListingsQualificiations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85b5fb6b-48a8-43fd-93b5-ed8600855053");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99ef15aa-491d-43dd-9420-7f213530d9fc");

            migrationBuilder.DropColumn(
                name: "Qualifications",
                table: "AllJobListings");

            migrationBuilder.AlterColumn<string>(
                name: "PrimaryPhoneNumber",
                table: "ApplicantBioData",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "ApplicantBioData",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Certificate",
                table: "AllJobListings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Diploma",
                table: "AllJobListings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Doctorate",
                table: "AllJobListings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MastersDegree",
                table: "AllJobListings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bachelorsDegree",
                table: "AllJobListings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "788b7b71-f9d1-41f3-981f-c317a2472805", "155dabf2-dc8b-42e6-8a8f-04423fa690a5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b25d020-9d3b-4faa-a9a1-01f36370de99", "32e702f8-97f1-410b-acbb-2cbda18c43a5", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "788b7b71-f9d1-41f3-981f-c317a2472805");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b25d020-9d3b-4faa-a9a1-01f36370de99");

            migrationBuilder.DropColumn(
                name: "Certificate",
                table: "AllJobListings");

            migrationBuilder.DropColumn(
                name: "Diploma",
                table: "AllJobListings");

            migrationBuilder.DropColumn(
                name: "Doctorate",
                table: "AllJobListings");

            migrationBuilder.DropColumn(
                name: "MastersDegree",
                table: "AllJobListings");

            migrationBuilder.DropColumn(
                name: "bachelorsDegree",
                table: "AllJobListings");

            migrationBuilder.AlterColumn<string>(
                name: "PrimaryPhoneNumber",
                table: "ApplicantBioData",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "ApplicantBioData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Qualifications",
                table: "AllJobListings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85b5fb6b-48a8-43fd-93b5-ed8600855053", "5cfd37f5-3f23-4669-9f19-d729e4d6aaa1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99ef15aa-491d-43dd-9420-7f213530d9fc", "23e8eb9a-e3b5-46b1-93d8-5e3606daf22c", "Admin", "ADMIN" });
        }
    }
}

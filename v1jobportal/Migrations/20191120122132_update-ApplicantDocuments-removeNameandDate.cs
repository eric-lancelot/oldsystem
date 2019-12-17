using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace v1jobportal.Migrations
{
    public partial class updateApplicantDocumentsremoveNameandDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "DateOfCertification",
                table: "ApplicantDocuments");

            migrationBuilder.DropColumn(
                name: "InstitutionName",
                table: "ApplicantDocuments");

            migrationBuilder.AlterColumn<string>(
                name: "SummaryOfDuties",
                table: "EmploymentHistoryModel",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CertifyingInstitutionName",
                table: "CertificationsAndAwards",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CertificationName",
                table: "CertificationsAndAwards",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrimaryPhoneNumber",
                table: "ApplicantBioData",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85b5fb6b-48a8-43fd-93b5-ed8600855053", "5cfd37f5-3f23-4669-9f19-d729e4d6aaa1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99ef15aa-491d-43dd-9420-7f213530d9fc", "23e8eb9a-e3b5-46b1-93d8-5e3606daf22c", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85b5fb6b-48a8-43fd-93b5-ed8600855053");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99ef15aa-491d-43dd-9420-7f213530d9fc");

            migrationBuilder.AlterColumn<string>(
                name: "SummaryOfDuties",
                table: "EmploymentHistoryModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CertifyingInstitutionName",
                table: "CertificationsAndAwards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CertificationName",
                table: "CertificationsAndAwards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCertification",
                table: "ApplicantDocuments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InstitutionName",
                table: "ApplicantDocuments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrimaryPhoneNumber",
                table: "ApplicantBioData",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a349c983-06c9-46fd-abd6-3482f52ad796", "d9caa6c3-2d9f-4aeb-8177-8eb8af39270a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bec50c2d-3c4e-4a06-a87f-b3265ca16db6", "d5aaf236-e9c1-4118-b6b1-07b198537376", "Admin", "ADMIN" });
        }
    }
}

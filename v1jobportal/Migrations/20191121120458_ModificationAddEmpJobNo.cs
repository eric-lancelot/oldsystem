using Microsoft.EntityFrameworkCore.Migrations;

namespace v1jobportal.Migrations
{
    public partial class ModificationAddEmpJobNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "083330d9-a428-49aa-8db4-8d418846fa89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "437a5e2d-d675-467f-bcce-313009903087");

            migrationBuilder.DropColumn(
                name: "Jd_JobTitle",
                table: "PendingApplications");

            migrationBuilder.AddColumn<int>(
                name: "Emp_Id",
                table: "PendingApplications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Emp_Id",
                table: "ApplicantDocuments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Jd_JobId",
                table: "ApplicantDocuments",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4343fb1-2cca-460d-98ba-7ec8462a6186", "f1e98a2b-bf8d-46c8-9794-8d81fc67645b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da558dea-8928-4716-8900-3eaca0423658", "6a400ecd-7bda-4c2e-bfba-79c9fe09f44e", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4343fb1-2cca-460d-98ba-7ec8462a6186");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da558dea-8928-4716-8900-3eaca0423658");

            migrationBuilder.DropColumn(
                name: "Emp_Id",
                table: "PendingApplications");

            migrationBuilder.DropColumn(
                name: "Emp_Id",
                table: "ApplicantDocuments");

            migrationBuilder.DropColumn(
                name: "Jd_JobId",
                table: "ApplicantDocuments");

            migrationBuilder.AddColumn<string>(
                name: "Jd_JobTitle",
                table: "PendingApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "083330d9-a428-49aa-8db4-8d418846fa89", "a53ea035-06bf-41ba-a739-0fbc2be87b51", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "437a5e2d-d675-467f-bcce-313009903087", "a195d66e-9577-4a9a-bffa-7e363923d92c", "Admin", "ADMIN" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace v1jobportal.Migrations
{
    public partial class AddScheduleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "617f72ff-6ef3-4b8e-9c61-2ecbc023b139");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93647892-215e-4faa-9639-376978628cde");

            migrationBuilder.AddColumn<byte>(
                name: "UploadCoverLetter",
                table: "ApplicantDocuments",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "UploadCv",
                table: "ApplicantDocuments",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleCv = table.Column<long>(nullable: false),
                    ScheduleCoverLeter = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "083330d9-a428-49aa-8db4-8d418846fa89", "a53ea035-06bf-41ba-a739-0fbc2be87b51", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "437a5e2d-d675-467f-bcce-313009903087", "a195d66e-9577-4a9a-bffa-7e363923d92c", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "083330d9-a428-49aa-8db4-8d418846fa89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "437a5e2d-d675-467f-bcce-313009903087");

            migrationBuilder.DropColumn(
                name: "UploadCoverLetter",
                table: "ApplicantDocuments");

            migrationBuilder.DropColumn(
                name: "UploadCv",
                table: "ApplicantDocuments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93647892-215e-4faa-9639-376978628cde", "2b5ccddc-2b04-46dd-a874-59901fd2a039", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "617f72ff-6ef3-4b8e-9c61-2ecbc023b139", "09a3e2be-dc7c-4acc-93a6-d8a5681ed7a8", "Admin", "ADMIN" });
        }
    }
}

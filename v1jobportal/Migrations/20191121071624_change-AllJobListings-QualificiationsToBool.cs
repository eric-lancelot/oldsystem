using Microsoft.EntityFrameworkCore.Migrations;

namespace v1jobportal.Migrations
{
    public partial class changeAllJobListingsQualificiationsToBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "788b7b71-f9d1-41f3-981f-c317a2472805");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b25d020-9d3b-4faa-a9a1-01f36370de99");

            migrationBuilder.AlterColumn<string>(
                name: "bachelorsDegree",
                table: "AllJobListings",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "MastersDegree",
                table: "AllJobListings",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Doctorate",
                table: "AllJobListings",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Diploma",
                table: "AllJobListings",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Certificate",
                table: "AllJobListings",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed3679e8-f69a-4af8-b1dc-4ae6485ef317", "83ed875e-dc86-408a-a107-339d200a190f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b2c04fd-b868-480a-896c-22df2177cb5b", "f3e31f02-c94c-424b-a316-fa2bf5446fc6", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b2c04fd-b868-480a-896c-22df2177cb5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed3679e8-f69a-4af8-b1dc-4ae6485ef317");

            migrationBuilder.AlterColumn<bool>(
                name: "bachelorsDegree",
                table: "AllJobListings",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "MastersDegree",
                table: "AllJobListings",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Doctorate",
                table: "AllJobListings",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Diploma",
                table: "AllJobListings",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Certificate",
                table: "AllJobListings",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "788b7b71-f9d1-41f3-981f-c317a2472805", "155dabf2-dc8b-42e6-8a8f-04423fa690a5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b25d020-9d3b-4faa-a9a1-01f36370de99", "32e702f8-97f1-410b-acbb-2cbda18c43a5", "Admin", "ADMIN" });
        }
    }
}

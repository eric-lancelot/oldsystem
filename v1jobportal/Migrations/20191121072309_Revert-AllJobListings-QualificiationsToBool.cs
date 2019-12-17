using Microsoft.EntityFrameworkCore.Migrations;

namespace v1jobportal.Migrations
{
    public partial class RevertAllJobListingsQualificiationsToBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "MastersDegree",
                table: "AllJobListings",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Doctorate",
                table: "AllJobListings",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Diploma",
                table: "AllJobListings",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Certificate",
                table: "AllJobListings",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9ab140d-fd9f-42cc-9dd0-af64f3b70849", "7f20f3b1-bf20-496c-9b69-a9e1eba913f1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "934b26f3-606c-428f-8cf3-3ae6d1ca358a", "9b4f7ec5-ff5e-4cd6-99d8-751f0b6ea6c8", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "934b26f3-606c-428f-8cf3-3ae6d1ca358a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9ab140d-fd9f-42cc-9dd0-af64f3b70849");

            migrationBuilder.AlterColumn<string>(
                name: "bachelorsDegree",
                table: "AllJobListings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "MastersDegree",
                table: "AllJobListings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Doctorate",
                table: "AllJobListings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Diploma",
                table: "AllJobListings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Certificate",
                table: "AllJobListings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed3679e8-f69a-4af8-b1dc-4ae6485ef317", "83ed875e-dc86-408a-a107-339d200a190f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b2c04fd-b868-480a-896c-22df2177cb5b", "f3e31f02-c94c-424b-a316-fa2bf5446fc6", "Admin", "ADMIN" });
        }
    }
}

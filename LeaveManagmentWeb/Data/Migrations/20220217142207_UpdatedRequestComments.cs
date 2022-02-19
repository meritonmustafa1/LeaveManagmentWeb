using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5ab2b-9773-420c-8002-221b7a5733bb",
                column: "ConcurrencyStamp",
                value: "fd2a6eaf-0033-4794-9e1b-18a8448d150a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5af7b-7b73-42c-8002-471b7a5733bc",
                column: "ConcurrencyStamp",
                value: "63e8cf62-ed71-4f94-ae5e-8f71c925dc75");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa5ba2b-9773-420c-8002-221b7a5733ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9da366ee-17e3-4159-80e0-412266c97047", "AQAAAAEAACcQAAAAEN2ZbuSuQGBqEKLE8JtYORbXJpOlkI6yLAuPyubhDWrjliQT+xdvBOxlvTKzDtQSpw==", "6b93cd8c-a41e-4662-be73-52564767b981" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72811880-5501-4468-bb0d-399e1ca1d9f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8931ca73-6c46-439c-92d8-643a10930868", "AQAAAAEAACcQAAAAELS+kw4L0FtMpwL77pz/K+Vh9ybICUsxWe8wzOCPbtQU5kXTK+3Tup4ABaOOQecYAg==", "b38b8dd0-3a62-44ac-a033-f8d2d6b6daa7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5ab2b-9773-420c-8002-221b7a5733bb",
                column: "ConcurrencyStamp",
                value: "e73176e2-44e1-42fe-96db-58029ab5d499");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5af7b-7b73-42c-8002-471b7a5733bc",
                column: "ConcurrencyStamp",
                value: "7b835eda-7a48-411a-b9ac-9cf5a55f5f6a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa5ba2b-9773-420c-8002-221b7a5733ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d9fe7fa-40c7-4c57-889e-f45f48b8f3d6", "AQAAAAEAACcQAAAAELDafGVHEnktSThjhbn0g5iga8pNOCjURTEbnxNih1IDg93BM+WZDPaBnMutVyl7uw==", "f2a523f1-86c2-474d-87e2-2a40ac523d97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72811880-5501-4468-bb0d-399e1ca1d9f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fc9842d-f3f4-4821-8e2d-6c7039fbe9d3", "AQAAAAEAACcQAAAAEKE364V4bXnQkhhkStFgZzTz2cRUqyDD6e8znZNvepqiHe7iPwvY5yncuDvpWL4zWA==", "1799854e-4914-455e-989d-ae58327fc78c" });
        }
    }
}

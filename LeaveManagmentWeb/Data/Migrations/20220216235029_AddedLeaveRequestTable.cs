using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5ab2b-9773-420c-8002-221b7a5733bb",
                column: "ConcurrencyStamp",
                value: "a7f0c6fd-9ca9-4410-98fd-b0093d20dc00");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5af7b-7b73-42c-8002-471b7a5733bc",
                column: "ConcurrencyStamp",
                value: "e7fa9977-88c9-4248-9760-aa5cecd2f642");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa5ba2b-9773-420c-8002-221b7a5733ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbb2ab05-6a26-4f98-81b4-3d91856a891f", "AQAAAAEAACcQAAAAED1J6HoUUvveO0j/UDPnYJAPrTZrYa1ptGRCyrhaKc5W8z4O1bEuo4uAkMKwYbKziA==", "26fb87dd-f471-4940-be64-905c69aa9ded" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72811880-5501-4468-bb0d-399e1ca1d9f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2287624-6452-448c-9ec4-f91809db1de3", "AQAAAAEAACcQAAAAEC5p5lBYG+90/L3+d7bz/iQFngsI1vEKimofU1Xy3+iVDHsb1at4uFf6FgdtBq12Pw==", "c3e77411-8a3b-4cc4-b2c5-9dae868cc822" });
        }
    }
}

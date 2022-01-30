using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2bb5ab2b-9773-420c-8002-221b7a5733bb", "dac9ff75-308d-46dd-b05d-5b75022dba1d", "Administrator", "ADMINISTRATOR" },
                    { "2bb5af7b-7b73-42c-8002-471b7a5733bc", "912d5702-4bdb-4c42-9af5-f77623582d68", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2aa5ba2b-9773-420c-8002-221b7a5733ad", 0, "bd09ccc2-a00f-45c0-94ec-1e293d0509e2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "m.te@g.com", false, "System", "User", false, null, "M.TE@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJmNox85N96n+EFxprR3X8f/G6GsYw2UB16V5nAn4210NrXV6VtJnmWVcdArAiN4Mg==", null, false, "cf9c383e-4a2b-4266-b67d-ad6bcd00e641", null, false, null },
                    { "72811880-5501-4468-bb0d-399e1ca1d9f4", 0, "e626cb72-9eb7-4285-bf6a-fb2dbc650653", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEJwAosTgFr2cVdu+qbcn63mlOo4tEwZnTEBUQgd1cpx4gz4BTkH51njMfIpKYvY4tA==", null, false, "da3f58e3-096a-40e5-900d-926c2ea639af", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2bb5af7b-7b73-42c-8002-471b7a5733bc", "2aa5ba2b-9773-420c-8002-221b7a5733ad" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2bb5ab2b-9773-420c-8002-221b7a5733bb", "72811880-5501-4468-bb0d-399e1ca1d9f4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2bb5af7b-7b73-42c-8002-471b7a5733bc", "2aa5ba2b-9773-420c-8002-221b7a5733ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2bb5ab2b-9773-420c-8002-221b7a5733bb", "72811880-5501-4468-bb0d-399e1ca1d9f4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5ab2b-9773-420c-8002-221b7a5733bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5af7b-7b73-42c-8002-471b7a5733bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa5ba2b-9773-420c-8002-221b7a5733ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72811880-5501-4468-bb0d-399e1ca1d9f4");
        }
    }
}

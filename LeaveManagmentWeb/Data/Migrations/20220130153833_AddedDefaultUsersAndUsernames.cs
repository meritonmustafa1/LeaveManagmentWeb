using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5ab2b-9773-420c-8002-221b7a5733bb",
                column: "ConcurrencyStamp",
                value: "dd8ad66d-145d-42be-b8a7-4640efbb4eb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5af7b-7b73-42c-8002-471b7a5733bc",
                column: "ConcurrencyStamp",
                value: "2f700ef9-0e35-46ee-93a8-44f1d2580d9e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa5ba2b-9773-420c-8002-221b7a5733ad",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "125dbd60-830d-4ff7-ba07-3609e2eb7024", true, "M.TE@GMAIL.COM", "AQAAAAEAACcQAAAAEMCWZyA1UeR9dI0It7CL8/NHhs+aBL9t2iM1yiYWZXExH9N4CChEdDHezmxSqTAnpQ==", "9ceadbfd-c006-4613-af39-7ec575b12fa7", "m.te@g.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72811880-5501-4468-bb0d-399e1ca1d9f4",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d3f6a9ad-8dbd-4210-9841-012fc4271f6f", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEafGWaAKJF+zZ4RGk5a7/k6IHqkIBPPwzDShshgFQHeUfqfhWSEv6vNG2OEolrjcw==", "ec79c052-6aa2-4ea6-bb47-87538f229574", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5ab2b-9773-420c-8002-221b7a5733bb",
                column: "ConcurrencyStamp",
                value: "dac9ff75-308d-46dd-b05d-5b75022dba1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5af7b-7b73-42c-8002-471b7a5733bc",
                column: "ConcurrencyStamp",
                value: "912d5702-4bdb-4c42-9af5-f77623582d68");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa5ba2b-9773-420c-8002-221b7a5733ad",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bd09ccc2-a00f-45c0-94ec-1e293d0509e2", false, null, "AQAAAAEAACcQAAAAEJmNox85N96n+EFxprR3X8f/G6GsYw2UB16V5nAn4210NrXV6VtJnmWVcdArAiN4Mg==", "cf9c383e-4a2b-4266-b67d-ad6bcd00e641", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72811880-5501-4468-bb0d-399e1ca1d9f4",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e626cb72-9eb7-4285-bf6a-fb2dbc650653", false, null, "AQAAAAEAACcQAAAAEJwAosTgFr2cVdu+qbcn63mlOo4tEwZnTEBUQgd1cpx4gz4BTkH51njMfIpKYvY4tA==", "da3f58e3-096a-40e5-900d-926c2ea639af", null });
        }
    }
}

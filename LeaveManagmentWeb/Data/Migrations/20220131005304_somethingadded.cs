using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class somethingadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5ab2b-9773-420c-8002-221b7a5733bb",
                column: "ConcurrencyStamp",
                value: "51001abf-ffb9-4053-991e-08ca20fbdea2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb5af7b-7b73-42c-8002-471b7a5733bc",
                column: "ConcurrencyStamp",
                value: "757922e8-a3b2-45ae-be78-66c14713b38e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2aa5ba2b-9773-420c-8002-221b7a5733ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e72c042d-ee5d-4dec-824e-d97740da0298", "AQAAAAEAACcQAAAAEOhYtmeEh9LXy0EYaD2kYlzYkGLpyAnNC/GAGb8XSQdfQDYhgIByAuY/aGAo/BgFwQ==", "9ea65790-bfd3-4ad4-8bd9-96af62ca8d5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72811880-5501-4468-bb0d-399e1ca1d9f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbf405fc-bf18-4084-bcca-20c979a9e8da", "AQAAAAEAACcQAAAAEMQmrNCBkthqInfdqhfMnaOD5rR5PJikZtYKkY0bQEvUG2an10crWuNpFTBBzInsBw==", "669aaebd-73f2-4013-a977-edbb2f5ce4a6" });
        }
    }
}

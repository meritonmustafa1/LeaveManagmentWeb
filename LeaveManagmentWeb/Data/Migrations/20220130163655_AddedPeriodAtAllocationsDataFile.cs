using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class AddedPeriodAtAllocationsDataFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "125dbd60-830d-4ff7-ba07-3609e2eb7024", "AQAAAAEAACcQAAAAEMCWZyA1UeR9dI0It7CL8/NHhs+aBL9t2iM1yiYWZXExH9N4CChEdDHezmxSqTAnpQ==", "9ceadbfd-c006-4613-af39-7ec575b12fa7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72811880-5501-4468-bb0d-399e1ca1d9f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3f6a9ad-8dbd-4210-9841-012fc4271f6f", "AQAAAAEAACcQAAAAEEafGWaAKJF+zZ4RGk5a7/k6IHqkIBPPwzDShshgFQHeUfqfhWSEv6vNG2OEolrjcw==", "ec79c052-6aa2-4ea6-bb47-87538f229574" });
        }
    }
}

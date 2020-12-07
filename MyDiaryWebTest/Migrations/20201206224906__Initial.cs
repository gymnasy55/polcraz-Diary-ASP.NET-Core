using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDiaryWebTest.Migrations
{
    public partial class _Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10568-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "7b64c200-fe42-4aa9-9585-96b602742310");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f3617afa-5758-4bb3-ac90-beb825027cfd", "AQAAAAEAACcQAAAAEAVKHqQ1p6jPz0+3ciPy8Rke5j0dkGGGLoDUiu63ms6xAdi72pGNmQb45uMN0Xqocg==" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("150e2590-46b4-4ee9-8256-1b4b84dbc670"),
                column: "DateAdded",
                value: new DateTime(2020, 12, 6, 22, 49, 5, 841, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("154d9d96-7f2b-400e-a309-e4168af164d5"),
                column: "DateAdded",
                value: new DateTime(2020, 12, 6, 22, 49, 5, 841, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "DateAdded", "Text", "Title", "UserId" },
                values: new object[] { new Guid("b78367f1-c042-4ce6-9bd7-234f880ab1df"), new DateTime(2020, 12, 6, 22, 49, 5, 841, DateTimeKind.Utc).AddTicks(5297), "TestNoteText3", "TestNoteTitle3", new Guid("82dad1b6-5b56-4fad-8892-b9d9026d510e") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("b78367f1-c042-4ce6-9bd7-234f880ab1df"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10568-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "f54590b6-a115-49dc-b162-f328ab72334d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afde7869-52ac-424a-a52f-a16cad5b4e8e", "AQAAAAEAACcQAAAAEH2WTHfEfGwOoTWl+Re7mHNEXsdkdYJdvPYlbbh2q1aNH7eeOCFxCPNnCq4gtoxzcQ==" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("150e2590-46b4-4ee9-8256-1b4b84dbc670"),
                column: "DateAdded",
                value: new DateTime(2020, 12, 6, 22, 41, 49, 296, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("154d9d96-7f2b-400e-a309-e4168af164d5"),
                column: "DateAdded",
                value: new DateTime(2020, 12, 6, 22, 41, 49, 297, DateTimeKind.Utc).AddTicks(983));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConverterAPI.Migrations
{
    public partial class MyCoreAPIDemoEntitiesAuditContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserAction",
                keyColumn: "ID",
                keyValue: new Guid("56d4d23a-aa4e-482d-89a4-9982ee5c439f"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserAction",
                keyColumn: "ID",
                keyValue: new Guid("b53f5624-eeae-485d-83b6-e1cb73c7e001"));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserAction",
                columns: new[] { "ID", "DateTimeStamp", "FromUnit", "Initial", "ToUnit", "Username", "Value" },
                values: new object[] { new Guid("76b1faa0-77f5-4e0a-b7fb-159a53697ce1"), new DateTime(2019, 6, 11, 18, 50, 47, 535, DateTimeKind.Local).AddTicks(8575), "KM", 0.0, "Mile", "Bob", 0.0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserAction",
                columns: new[] { "ID", "DateTimeStamp", "FromUnit", "Initial", "ToUnit", "Username", "Value" },
                values: new object[] { new Guid("f8dae740-71c9-4edd-807e-279210ff958e"), new DateTime(2019, 6, 11, 18, 50, 47, 540, DateTimeKind.Local).AddTicks(3520), "Mile", 0.0, "KM", "John", 0.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserAction",
                keyColumn: "ID",
                keyValue: new Guid("76b1faa0-77f5-4e0a-b7fb-159a53697ce1"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserAction",
                keyColumn: "ID",
                keyValue: new Guid("f8dae740-71c9-4edd-807e-279210ff958e"));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserAction",
                columns: new[] { "ID", "DateTimeStamp", "FromUnit", "Initial", "ToUnit", "Username", "Value" },
                values: new object[] { new Guid("b53f5624-eeae-485d-83b6-e1cb73c7e001"), new DateTime(2019, 6, 11, 18, 49, 50, 25, DateTimeKind.Local).AddTicks(7783), "KM", 0.0, "Mile", "Bob", 0.0 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserAction",
                columns: new[] { "ID", "DateTimeStamp", "FromUnit", "Initial", "ToUnit", "Username", "Value" },
                values: new object[] { new Guid("56d4d23a-aa4e-482d-89a4-9982ee5c439f"), new DateTime(2019, 6, 11, 18, 49, 50, 30, DateTimeKind.Local).AddTicks(4223), "Mile", 0.0, "KM", "John", 0.0 });
        }
    }
}

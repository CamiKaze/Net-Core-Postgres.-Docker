using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConverterAPI.Migrations
{
    public partial class MyCoreAPIDemoEntitiesAuditContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "UserAction",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    FromUnit = table.Column<string>(maxLength: 50, nullable: false),
                    Initial = table.Column<double>(maxLength: 50, nullable: false),
                    ToUnit = table.Column<string>(maxLength: 50, nullable: false),
                    Value = table.Column<double>(maxLength: 50, nullable: false),
                    DateTimeStamp = table.Column<DateTime>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAction", x => x.ID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAction",
                schema: "dbo");
        }
    }
}

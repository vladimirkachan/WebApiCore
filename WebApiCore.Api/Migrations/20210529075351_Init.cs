using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCore.Api.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperature = table.Column<double>(type: "float", nullable: false),
                    MinTemperature = table.Column<double>(type: "float", nullable: false),
                    MaxTemperature = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Email", "Name" },
                values: new object[,]
                {
                    { "1", new DateTime(2000, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "vasyavetrov@mail.ru", "Vasya" },
                    { "2", new DateTime(2001, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maria" }
                });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "MaxTemperature", "MinTemperature", "Status", "Temperature" },
                values: new object[,]
                {
                    { 10, 5.25, -50.0, "snowy", -10.5 },
                    { 20, 0.0, 0.0, "windy", 20.370000000000001 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Weathers");
        }
    }
}

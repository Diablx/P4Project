using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealership.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Car_ID = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    Salesman = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    VIN = table.Column<string>(maxLength: 17, nullable: false),
                    Brand = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Engine = table.Column<int>(maxLength: 6, nullable: false),
                    HP = table.Column<int>(maxLength: 4, nullable: false),
                    ProductionYear = table.Column<DateTime>(nullable: false),
                    Mileage = table.Column<int>(maxLength: 8, nullable: false),
                    Combustion = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Condition = table.Column<string>(nullable: true),
                    Gearbox = table.Column<string>(nullable: true),
                    GPS = table.Column<bool>(nullable: false),
                    ESP = table.Column<bool>(nullable: false),
                    AC = table.Column<bool>(nullable: false),
                    ParkAssist = table.Column<bool>(nullable: false),
                    Shift_Paddles = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.VIN);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Pesel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Login = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Pesel);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}

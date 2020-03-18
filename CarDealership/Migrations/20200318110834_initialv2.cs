using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealership.Migrations
{
    public partial class initialv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Car_ID",
                table: "Advertisements",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CarVIN",
                table: "Advertisements",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonPesel",
                table: "Advertisements",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_CarVIN",
                table: "Advertisements",
                column: "CarVIN");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_PersonPesel",
                table: "Advertisements",
                column: "PersonPesel");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Cars_CarVIN",
                table: "Advertisements",
                column: "CarVIN",
                principalTable: "Cars",
                principalColumn: "VIN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_People_PersonPesel",
                table: "Advertisements",
                column: "PersonPesel",
                principalTable: "People",
                principalColumn: "Pesel",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Cars_CarVIN",
                table: "Advertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_People_PersonPesel",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_CarVIN",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_PersonPesel",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "CarVIN",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "PersonPesel",
                table: "Advertisements");

            migrationBuilder.AlterColumn<int>(
                name: "Car_ID",
                table: "Advertisements",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

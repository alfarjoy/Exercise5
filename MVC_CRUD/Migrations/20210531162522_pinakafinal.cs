using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_CRUD.Migrations
{
    public partial class pinakafinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Date_TimeIn",
                table: "Users",
                newName: "Bdate");

            migrationBuilder.AddColumn<string>(
                name: "Placeofbirth",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Placeofbirth",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Bdate",
                table: "Users",
                newName: "Date_TimeIn");

            migrationBuilder.AddColumn<double>(
                name: "Temperature",
                table: "Users",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}

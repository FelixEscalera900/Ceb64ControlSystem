using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEB64ControlSystem.Migrations
{
    public partial class addedsexotoalumnos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Alumnos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Alumnos");
        }
    }
}

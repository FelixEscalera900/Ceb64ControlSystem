using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEB64ControlSystem.Migrations
{
    public partial class createdabstractions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Grupos",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Grupos",
                newName: "id");
        }
    }
}

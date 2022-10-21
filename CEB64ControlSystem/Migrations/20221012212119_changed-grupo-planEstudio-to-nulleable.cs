using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEB64ControlSystem.Migrations
{
    public partial class changedgrupoplanEstudiotonulleable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_PlanEstudio_PlanEstudioId",
                table: "Grupos");

            migrationBuilder.AlterColumn<int>(
                name: "PlanEstudioId",
                table: "Grupos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_PlanEstudio_PlanEstudioId",
                table: "Grupos",
                column: "PlanEstudioId",
                principalTable: "PlanEstudio",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_PlanEstudio_PlanEstudioId",
                table: "Grupos");

            migrationBuilder.AlterColumn<int>(
                name: "PlanEstudioId",
                table: "Grupos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_PlanEstudio_PlanEstudioId",
                table: "Grupos",
                column: "PlanEstudioId",
                principalTable: "PlanEstudio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

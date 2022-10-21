using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEB64ControlSystem.Migrations
{
    public partial class createdsemestretipos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Periodo_PeriodoId",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_PlanEstudio_PlanEstudioId",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_HoraClase_Periodo_PeriodoId",
                table: "HoraClase");

            migrationBuilder.DropForeignKey(
                name: "FK_MateriaPlanEstudio_PlanEstudio_PlanEstudiosId",
                table: "MateriaPlanEstudio");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanEstudio_Periodo_PeriodoId",
                table: "PlanEstudio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanEstudio",
                table: "PlanEstudio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Periodo",
                table: "Periodo");

            migrationBuilder.RenameTable(
                name: "PlanEstudio",
                newName: "planEstudios");

            migrationBuilder.RenameTable(
                name: "Periodo",
                newName: "Periodos");

            migrationBuilder.RenameIndex(
                name: "IX_PlanEstudio_PeriodoId",
                table: "planEstudios",
                newName: "IX_planEstudios_PeriodoId");

            migrationBuilder.AddColumn<int>(
                name: "PeriodoTipoId",
                table: "Semestres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PeriodoTipoId",
                table: "Periodos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_planEstudios",
                table: "planEstudios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Periodos",
                table: "Periodos",
                column: "PeriodoId");

            migrationBuilder.CreateTable(
                name: "PeriodoTipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodoTipo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Semestres_PeriodoTipoId",
                table: "Semestres",
                column: "PeriodoTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Periodos_PeriodoTipoId",
                table: "Periodos",
                column: "PeriodoTipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Periodos_PeriodoId",
                table: "Grupos",
                column: "PeriodoId",
                principalTable: "Periodos",
                principalColumn: "PeriodoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_planEstudios_PlanEstudioId",
                table: "Grupos",
                column: "PlanEstudioId",
                principalTable: "planEstudios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HoraClase_Periodos_PeriodoId",
                table: "HoraClase",
                column: "PeriodoId",
                principalTable: "Periodos",
                principalColumn: "PeriodoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaPlanEstudio_planEstudios_PlanEstudiosId",
                table: "MateriaPlanEstudio",
                column: "PlanEstudiosId",
                principalTable: "planEstudios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Periodos_PeriodoTipo_PeriodoTipoId",
                table: "Periodos",
                column: "PeriodoTipoId",
                principalTable: "PeriodoTipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_planEstudios_Periodos_PeriodoId",
                table: "planEstudios",
                column: "PeriodoId",
                principalTable: "Periodos",
                principalColumn: "PeriodoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Semestres_PeriodoTipo_PeriodoTipoId",
                table: "Semestres",
                column: "PeriodoTipoId",
                principalTable: "PeriodoTipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Periodos_PeriodoId",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_planEstudios_PlanEstudioId",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_HoraClase_Periodos_PeriodoId",
                table: "HoraClase");

            migrationBuilder.DropForeignKey(
                name: "FK_MateriaPlanEstudio_planEstudios_PlanEstudiosId",
                table: "MateriaPlanEstudio");

            migrationBuilder.DropForeignKey(
                name: "FK_Periodos_PeriodoTipo_PeriodoTipoId",
                table: "Periodos");

            migrationBuilder.DropForeignKey(
                name: "FK_planEstudios_Periodos_PeriodoId",
                table: "planEstudios");

            migrationBuilder.DropForeignKey(
                name: "FK_Semestres_PeriodoTipo_PeriodoTipoId",
                table: "Semestres");

            migrationBuilder.DropTable(
                name: "PeriodoTipo");

            migrationBuilder.DropIndex(
                name: "IX_Semestres_PeriodoTipoId",
                table: "Semestres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_planEstudios",
                table: "planEstudios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Periodos",
                table: "Periodos");

            migrationBuilder.DropIndex(
                name: "IX_Periodos_PeriodoTipoId",
                table: "Periodos");

            migrationBuilder.DropColumn(
                name: "PeriodoTipoId",
                table: "Semestres");

            migrationBuilder.DropColumn(
                name: "PeriodoTipoId",
                table: "Periodos");

            migrationBuilder.RenameTable(
                name: "planEstudios",
                newName: "PlanEstudio");

            migrationBuilder.RenameTable(
                name: "Periodos",
                newName: "Periodo");

            migrationBuilder.RenameIndex(
                name: "IX_planEstudios_PeriodoId",
                table: "PlanEstudio",
                newName: "IX_PlanEstudio_PeriodoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanEstudio",
                table: "PlanEstudio",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Periodo",
                table: "Periodo",
                column: "PeriodoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Periodo_PeriodoId",
                table: "Grupos",
                column: "PeriodoId",
                principalTable: "Periodo",
                principalColumn: "PeriodoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_PlanEstudio_PlanEstudioId",
                table: "Grupos",
                column: "PlanEstudioId",
                principalTable: "PlanEstudio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HoraClase_Periodo_PeriodoId",
                table: "HoraClase",
                column: "PeriodoId",
                principalTable: "Periodo",
                principalColumn: "PeriodoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MateriaPlanEstudio_PlanEstudio_PlanEstudiosId",
                table: "MateriaPlanEstudio",
                column: "PlanEstudiosId",
                principalTable: "PlanEstudio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanEstudio_Periodo_PeriodoId",
                table: "PlanEstudio",
                column: "PeriodoId",
                principalTable: "Periodo",
                principalColumn: "PeriodoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEB64ControlSystem.Migrations
{
    public partial class db_first_dep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlumnoEstados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlumnoEstados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiaClase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaClase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluacionCategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluacionCategoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Periodo",
                columns: table => new
                {
                    PeriodoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsTheCurrentPeriodo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodo", x => x.PeriodoId);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carrera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefonico = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Semestres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semestres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCalificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCalificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvaluacionCategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluacion_EvaluacionCategoria_EvaluacionCategoriaId",
                        column: x => x.EvaluacionCategoriaId,
                        principalTable: "EvaluacionCategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoraClase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraInicio = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraFinal = table.Column<TimeSpan>(type: "time", nullable: false),
                    PeriodoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoraClase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoraClase_Periodo_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "Periodo",
                        principalColumn: "PeriodoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlanEstudio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeriodoId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanEstudio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanEstudio_Periodo_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "Periodo",
                        principalColumn: "PeriodoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoCalificacionId = table.Column<int>(type: "int", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materia_TipoCalificacion_TipoCalificacionId",
                        column: x => x.TipoCalificacionId,
                        principalTable: "TipoCalificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SemestreID = table.Column<int>(type: "int", nullable: false),
                    PlanEstudioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Grupos_Periodo_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "Periodo",
                        principalColumn: "PeriodoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grupos_PlanEstudio_PlanEstudioId",
                        column: x => x.PlanEstudioId,
                        principalTable: "PlanEstudio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grupos_Semestres_SemestreID",
                        column: x => x.SemestreID,
                        principalTable: "Semestres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MateriaPlanEstudio",
                columns: table => new
                {
                    MateriasId = table.Column<int>(type: "int", nullable: false),
                    PlanEstudiosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaPlanEstudio", x => new { x.MateriasId, x.PlanEstudiosId });
                    table.ForeignKey(
                        name: "FK_MateriaPlanEstudio_Materia_MateriasId",
                        column: x => x.MateriasId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MateriaPlanEstudio_PlanEstudio_PlanEstudiosId",
                        column: x => x.PlanEstudiosId,
                        principalTable: "PlanEstudio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MateriaProfesor",
                columns: table => new
                {
                    MateriasId = table.Column<int>(type: "int", nullable: false),
                    ProfesoresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaProfesor", x => new { x.MateriasId, x.ProfesoresId });
                    table.ForeignKey(
                        name: "FK_MateriaProfesor_Materia_MateriasId",
                        column: x => x.MateriasId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MateriaProfesor_Profesor_ProfesoresId",
                        column: x => x.ProfesoresId,
                        principalTable: "Profesor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEgreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GrupoId = table.Column<int>(type: "int", nullable: true),
                    SemestreId = table.Column<int>(type: "int", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefonico = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alumnos_AlumnoEstados_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "AlumnoEstados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alumnos_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Alumnos_Semestres_SemestreId",
                        column: x => x.SemestreId,
                        principalTable: "Semestres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupoId = table.Column<int>(type: "int", nullable: false),
                    ProfesorID = table.Column<int>(type: "int", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asignaturas_Profesor_ProfesorID",
                        column: x => x.ProfesorID,
                        principalTable: "Profesor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlumnoContactos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Relacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlumnoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefonico = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlumnoContactos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlumnoContactos_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalificacionEvaluacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnoId = table.Column<int>(type: "int", nullable: false),
                    AsignaturaId = table.Column<int>(type: "int", nullable: false),
                    Calificacion = table.Column<int>(type: "int", nullable: false),
                    Faltas = table.Column<int>(type: "int", nullable: false),
                    EvaluacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalificacionEvaluacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalificacionEvaluacion_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalificacionEvaluacion_Asignaturas_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalificacionEvaluacion_Evaluacion_EvaluacionId",
                        column: x => x.EvaluacionId,
                        principalTable: "Evaluacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Horario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraClaseID = table.Column<int>(type: "int", nullable: false),
                    DiaClaseId = table.Column<int>(type: "int", nullable: false),
                    AsignaturaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horario_Asignaturas_AsignaturaID",
                        column: x => x.AsignaturaID,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Horario_DiaClase_DiaClaseId",
                        column: x => x.DiaClaseId,
                        principalTable: "DiaClase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Horario_HoraClase_HoraClaseID",
                        column: x => x.HoraClaseID,
                        principalTable: "HoraClase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoContactos_AlumnoId",
                table: "AlumnoContactos",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_GrupoId",
                table: "Alumnos",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_IdEstado",
                table: "Alumnos",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_SemestreId",
                table: "Alumnos",
                column: "SemestreId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_GrupoId",
                table: "Asignaturas",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_MateriaId",
                table: "Asignaturas",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_ProfesorID",
                table: "Asignaturas",
                column: "ProfesorID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionEvaluacion_AlumnoId",
                table: "CalificacionEvaluacion",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionEvaluacion_AsignaturaId",
                table: "CalificacionEvaluacion",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionEvaluacion_EvaluacionId",
                table: "CalificacionEvaluacion",
                column: "EvaluacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluacion_EvaluacionCategoriaId",
                table: "Evaluacion",
                column: "EvaluacionCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_PeriodoId",
                table: "Grupos",
                column: "PeriodoId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_PlanEstudioId",
                table: "Grupos",
                column: "PlanEstudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_SemestreID",
                table: "Grupos",
                column: "SemestreID");

            migrationBuilder.CreateIndex(
                name: "IX_HoraClase_PeriodoId",
                table: "HoraClase",
                column: "PeriodoId");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_AsignaturaID",
                table: "Horario",
                column: "AsignaturaID");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_DiaClaseId",
                table: "Horario",
                column: "DiaClaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_HoraClaseID",
                table: "Horario",
                column: "HoraClaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_TipoCalificacionId",
                table: "Materia",
                column: "TipoCalificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaPlanEstudio_PlanEstudiosId",
                table: "MateriaPlanEstudio",
                column: "PlanEstudiosId");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaProfesor_ProfesoresId",
                table: "MateriaProfesor",
                column: "ProfesoresId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanEstudio_PeriodoId",
                table: "PlanEstudio",
                column: "PeriodoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlumnoContactos");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CalificacionEvaluacion");

            migrationBuilder.DropTable(
                name: "Horario");

            migrationBuilder.DropTable(
                name: "MateriaPlanEstudio");

            migrationBuilder.DropTable(
                name: "MateriaProfesor");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Evaluacion");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "DiaClase");

            migrationBuilder.DropTable(
                name: "HoraClase");

            migrationBuilder.DropTable(
                name: "AlumnoEstados");

            migrationBuilder.DropTable(
                name: "EvaluacionCategoria");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Materia");

            migrationBuilder.DropTable(
                name: "Profesor");

            migrationBuilder.DropTable(
                name: "PlanEstudio");

            migrationBuilder.DropTable(
                name: "Semestres");

            migrationBuilder.DropTable(
                name: "TipoCalificacion");

            migrationBuilder.DropTable(
                name: "Periodo");
        }
    }
}

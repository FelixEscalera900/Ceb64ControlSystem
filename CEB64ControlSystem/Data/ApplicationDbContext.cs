using CEB64ControlSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CEB64ControlSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Grupo>()
                .HasOne(b => b.Semestre)
                .WithMany(i => i.Grupos)
                .HasForeignKey(b => b.SemestreID)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Grupo>()
                .HasOne(g => g.Periodo)
                .WithMany(g => g.Grupo)
                .HasForeignKey(g => g.PeriodoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AlumnoContacto>()
                .HasOne(AC => AC.Alumno)
                .WithMany(A => A.Contactos)
                .HasForeignKey(AC => AC.AlumnoId);

            modelBuilder.Entity<Alumno>()
                .HasOne(AC => AC.Semestre)
                .WithMany(A => A.Alumnos)
                .HasForeignKey(AC => AC.SemestreId)
                .OnDelete(DeleteBehavior.Restrict);
                
            modelBuilder.Entity<Alumno>()
                .HasOne(a => a.Grupo)
                .WithMany(gp => gp.Alumnos)
                .HasForeignKey(a => a.GrupoId)
                .OnDelete(DeleteBehavior.SetNull);
            
            modelBuilder.Entity<Alumno>()
                .HasOne(a => a.Estado)
                .WithMany(e => e.Alumnos)
                .HasForeignKey(a => a.IdEstado)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Materia>()
                .HasOne(m => m.TipoCalificacion)
                .WithMany(t => t.Materias)
                .HasForeignKey(m => m.TipoCalificacionId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Materia>()
                .HasMany(m => m.PlanEstudios)
                .WithMany(p => p.Materias);

            modelBuilder.Entity<PlanEstudio>()
                .HasOne(Pe => Pe.Periodo)
                .WithMany(p => p.PlanEstudios)
                .HasForeignKey(pe => pe.PeriodoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Materia>()
                .HasMany(m => m.Profesores)
                .WithMany(p => p.Materias);

            modelBuilder.Entity<Asignatura>()
                .HasOne(a => a.Grupo)
                .WithMany(GP => GP.Asignaturas)
                .HasForeignKey(a => a.GrupoId);

            modelBuilder.Entity<Asignatura>()
                .HasOne(a => a.Materia)
                .WithMany(GP => GP.Asignaturas)
                .HasForeignKey(a => a.MateriaId);

            modelBuilder.Entity<Asignatura>()
                .HasOne(a => a.Profesor)
                .WithMany(GP => GP.Asignaturas)
                .HasForeignKey(a => a.ProfesorID);

            modelBuilder.Entity<HoraClase>()
                .HasOne(p => p.Periodo)
                .WithMany(p => p.HoraClases)
                .HasForeignKey(p => p.PeriodoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Horario>()
                .HasOne(h => h.DiaClase)
                .WithMany(d => d.Horarios)
                .HasForeignKey(h => h.DiaClaseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Horario>()
                .HasOne(h => h.Asignatura)
                .WithMany(a => a.Horarios)
                .HasForeignKey(h => h.AsignaturaID);

            modelBuilder.Entity<Evaluacion>()
                .HasOne(e => e.EvaluacionCategoria)
                .WithMany(ec => ec.Evaluaciones)
                .HasForeignKey(e => e.EvaluacionCategoriaId);

            modelBuilder.Entity<CalificacionEvaluacion>()
                .HasOne(c => c.Evaluacion)
                .WithMany(a => a.CalificacionEvaluacions)
                .HasForeignKey(c => c.EvaluacionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CalificacionEvaluacion>()
                .HasOne(c => c.Alumno)
                .WithMany(a => a.CalificacionEvaluaciones)
                .HasForeignKey(c => c.AlumnoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CalificacionEvaluacion>()
                .HasOne(c => c.Asignatura)
                .WithMany(a => a.CalificacionEvaluaciones)
                .HasForeignKey(c => c.AsignaturaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Semestre>()
                .HasOne(s => s.PeriodoTipo)
                .WithMany(s => s.Semestres)
                .HasForeignKey(s => s.PeriodoTipoId);

            modelBuilder.Entity<Periodo>()
                .HasOne(s => s.PeriodoTipo)
                .WithMany(s => s.Periodos)
                .HasForeignKey(s => s.PeriodoTipoId);
        }
        public DbSet<Semestre> Semestres { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<AlumnoContacto> AlumnoContactos { get; set; }
        public DbSet<AlumnoEstado> AlumnoEstados { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Periodo> Periodos { get; set; }

        public DbSet<PlanEstudio> planEstudios { get; set; }
    }
}
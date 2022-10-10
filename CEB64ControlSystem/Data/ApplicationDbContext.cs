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

            modelBuilder.Entity<Grupo_Periodo>()
                .HasOne(g => g.Grupo)
                .WithMany(g => g.Grupo_periodo)
                .HasForeignKey(g => g.GrupoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Grupo_Periodo>()
                .HasOne(g => g.Periodo)
                .WithMany(g => g.Grupo_periodo)
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
                .HasOne(a => a.GrupoPeriodo)
                .WithMany(gp => gp.Alumnos)
                .HasForeignKey(a => a.GrupoPeriodoId)
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
                .HasOne(a => a.GrupoPeriodo)
                .WithMany(GP => GP.Asignaturas)
                .HasForeignKey(a => a.GrupoPeriodoId);

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
        }
        public DbSet<Semestre> Blogs { get; set; }
        public DbSet<Grupo> BlogImages { get; set; }
        public DbSet<Grupo_Periodo> Grupo_Periodos { get; set; }
    }
}
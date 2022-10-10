using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class CalificacionEvaluacion
    {
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
        public int AsignaturaId { get; set; }
        public Asignatura Asignatura { get; set; }
        [Display(Name = "Calificacion")]
        public int Calificacion { get; set; }
        [Display(Name = "Faltas")]
        public int Faltas { get; set; }
        public int EvaluacionId { get; set; }
        public Evaluacion Evaluacion { get; set; }
         
    }
}

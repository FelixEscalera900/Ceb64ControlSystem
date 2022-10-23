using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class Grupo
    {
        public int id { get; set; }
        public int PeriodoId { get; set; }
        public Periodo? Periodo { get; set; }
        
        [Display(Name = "Grupo")] 
        [Required]
        public string Name { get; set; }
        public List<Asignatura>? Asignaturas { get; set; }
        public List<Alumno>? Alumnos { get; set; }
        [Required]
        [Display(Name = "Semestre")]
        public int SemestreID { get; set; }
        public Semestre? Semestre { get; set; }
        public PlanEstudio? PlanEstudio { get; set; }
        public int? PlanEstudioId { get; set; }

    }
}

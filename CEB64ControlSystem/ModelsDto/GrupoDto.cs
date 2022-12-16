using CEB64ControlSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.ModelsDto
{
    public class GrupoDto :  KeyedDto
    {
        [Required]
        public int Id { get; set; }
        public int PeriodoId { get; set; }
        public Periodo? Periodo { get; set; }
        public List<Asignatura>? Asignaturas { get; set; }

        [Display(Name = "Grupo")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Semestre")]
        [Required]
        public int SemestreID { get; set; }
        public Semestre? Semestre { get; set; }
        public PlanEstudio? PlanEstudio { get; set; }
        public int? PlanEstudioId { get; set; }
        public List<AlumnoDto>? Alumnos { get; set; }
        [Display(Name = "#Alumnos")]
        public string? NumeroAlumnos { get; set; }

    }
}

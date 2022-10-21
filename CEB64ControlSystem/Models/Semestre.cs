using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class Semestre 
    {
        public int Id { get; set; }
        [Display(Name = "Semestre")]
        public string Name { get; set; }
        public List<Grupo> Grupos { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public PeriodoTipo PeriodoTipo { get; set; } 
        public int PeriodoTipoId { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class Semestre 
    {
        public int SemestreId { get; set; }
        [Display(Name = "Semestre")]
        public string SemestreName { get; set; }
        public List<Grupo> Grupos { get; set; }
        public List<Alumno> Alumnos { get; set; }

    }
}

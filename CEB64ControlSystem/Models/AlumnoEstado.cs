using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class AlumnoEstado
    {
        public int Id { get; set; }
        [Display(Name = "Estado")]
        public string Name { get; set; }
        public List<Alumno> Alumnos {get; set;}
    }
}

using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class Grupo
    {
        public int id { get; set; }
        public int PeriodoId { get; set; }
        public Periodo Periodo { get; set; }
        [Display(Name = "Grupo")]
        public int GrupoId { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public int SemestreID { get; set; }
        public Semestre Semestre { get; set; }

    }
}

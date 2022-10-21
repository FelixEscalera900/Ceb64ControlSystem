using CEB64ControlSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.ModelsDto
{
    public class GrupoDto
    {
        public int id { get; set; }
        public int PeriodoId { get; set; }
        public Periodo Periodo { get; set; }
        [Display(Name = "Grupo")]
        public string Name { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<AlumnoDto> Alumnos { get; set; }
        public int SemestreID { get; set; }
        public Semestre Semestre { get; set; }
        public PlanEstudio PlanEstudio { get; set; }
        public int? PlanEstudioId { get; set; }
        public List<AlumnoDto> OrderedAlumnos
        {
            get
            {
                return Alumnos.OrderBy(a => a.ApellidoPaterno).ToList();
            }
        }
        public int NumeroAlumnos
        {
            get
            {
                return Alumnos.Count;
            }
        }
    }
}

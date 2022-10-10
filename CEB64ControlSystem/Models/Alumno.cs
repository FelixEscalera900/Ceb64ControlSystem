using CEB64ControlSystem.AbstractModels;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class Alumno : PersonaContacto
    {
        public int Id { get; set; }
        [Display(Name = "Fecha Ingreso")]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Fecha de ingreso")]
        public DateTime FechaIngreso { get; set; }
        [Display(Name = "Fecha Egreso")]
        public DateTime? FechaEgreso { get; set; }
        public Grupo_Periodo? GrupoPeriodo { get; set; }
        public int? GrupoPeriodoId { get; set; }
        public Semestre Semestre { get; set; }
        public int SemestreId { get; set; }
        [Display(Name = "Contactos")]
        public List<AlumnoContacto> Contactos { get; set; }
        public int? IdEstado { get; set; }
        public AlumnoEstado Estado { get; set; }
        public List<CalificacionEvaluacion> CalificacionEvaluaciones {get; set; }

    }

}

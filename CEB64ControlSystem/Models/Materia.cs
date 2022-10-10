using CEB64ControlSystem.AbstractModels;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class Materia : ActivableModel
    {
        public int Id { get; set; }
        [Display(Name = "Materia")]
        public string Name { get; set; }
        public int? TipoCalificacionId { get; set; }
        public TipoCalificacion? TipoCalificacion { get; set; }
        public List<PlanEstudio> PlanEstudios { get; set; }
        public List<Profesor> Profesores { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
    }
}

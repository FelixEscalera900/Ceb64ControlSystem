using CEB64ControlSystem.AbstractModels;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class PlanEstudio : ActivableModel
    {
        public int Id { get; set; }
        [Display(Name = "Plan de Estudios")]
        public string Name { get; set; }
        public int PeriodoId { get; set; }
        public Periodo Periodo { get; set; }
        public List<Materia> Materias { get; set; }

    }
}

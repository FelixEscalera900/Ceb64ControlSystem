using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class Evaluacion
    {
        public int Id { get; set; }
        [Display(Name = "Evaluación")]
        public string Name { get; set; }
        public int EvaluacionCategoriaId { get; set; }
        public EvaluacionCategoria EvaluacionCategoria { get; set; }
        public List<CalificacionEvaluacion> CalificacionEvaluacions  { get; set; }

    }
}

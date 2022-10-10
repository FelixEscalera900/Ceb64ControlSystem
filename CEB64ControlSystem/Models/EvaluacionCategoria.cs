using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class EvaluacionCategoria
    {
        public int Id { get; set; }
        [Display(Name = "Tipo Evaluación")]
        public string Name { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }
    }
}

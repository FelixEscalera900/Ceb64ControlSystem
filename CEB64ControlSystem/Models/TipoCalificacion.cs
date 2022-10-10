using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class TipoCalificacion
    {
        public int Id { get; set; }
        [Display(Name = "Tipo de Calificación")]
        public string Name { get; set; }
        public List<Materia> Materias { get; set; }
    }

}

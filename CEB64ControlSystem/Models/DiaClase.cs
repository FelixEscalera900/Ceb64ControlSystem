using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class DiaClase
    {
        public int Id { get; set; }
        [Display(Name = "Dia")]
        public string Name { get; set; }
        public List<Horario> Horarios { get; set; }
    }
}

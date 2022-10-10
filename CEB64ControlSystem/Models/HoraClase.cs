using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class HoraClase
    {
        public int Id { get; set; }
        [Display(Name = "Hora de Inicio")]
        public TimeSpan HoraInicio { get; set; }
        [Display(Name = "Hora de Salida")]
        public TimeSpan HoraFinal { get; set; }
        public int PeriodoId { get; set; }
        public Periodo Periodo { get; set; }
    }
}

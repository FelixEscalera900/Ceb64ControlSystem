using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class Periodo
    {
        public int PeriodoId { get; set; }
        [Display(Name = "Periodo")]
        public string Name { get; set; }
        public bool IsTheCurrentPeriodo { get; set; }
        public List<Grupo> Grupo { get; set; }
        public List<PlanEstudio> PlanEstudios { get; set; }
        public List<HoraClase> HoraClases { get; set; }
    }
}

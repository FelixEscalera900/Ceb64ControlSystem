using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class Grupo
    {

        public int GrupoId { get; set; }
        [Display(Name = "Grupo")]
        public string Name { get; set; }
        public int SemestreID { get; set; }
        public Semestre Semestre { get; set; }
        public List<Grupo_Periodo> Grupo_periodo { get ; set; }
    }
}

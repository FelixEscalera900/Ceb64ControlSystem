namespace CEB64ControlSystem.Models
{
    public class PeriodoTipo
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public List<Semestre> Semestres { get; set; }
        public List<Periodo> Periodos { get; set; }
    }
}

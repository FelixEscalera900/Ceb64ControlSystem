namespace CEB64ControlSystem.Models
{
    public class Grupo_Periodo
    {
        public int id { get; set; }

        public int PeriodoId { get; set; }
        public Periodo Periodo { get; set; }
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }

    }
}

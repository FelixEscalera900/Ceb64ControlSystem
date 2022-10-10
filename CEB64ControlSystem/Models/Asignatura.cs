namespace CEB64ControlSystem.Models
{
    public class Asignatura 
    {
        public int Id { get; set; }
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public int ProfesorID { get; set; }
        public Profesor Profesor { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        public List<Horario> Horarios { get; set; }
        public List<CalificacionEvaluacion> CalificacionEvaluaciones { get; set; }
    }
}
 
using CEB64ControlSystem.AbstractModels;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class Profesor : PersonaContacto
    {
        public int Id { get; set; }
        public string Carrera { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set;}
        public bool Deleted { get ; set ; }
        public DateTime DeletedTime { get ; set ; }
        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; }
        public List<Materia> Materias { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
    }
}

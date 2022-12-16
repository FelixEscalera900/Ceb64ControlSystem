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
        public string Name { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public string NumeroTelefonico { get; set; }
        public string Mail { get; set; }
    }
}

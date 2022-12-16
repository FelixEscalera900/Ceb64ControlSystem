using CEB64ControlSystem.AbstractModels;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.Models
{
    public class Alumno : PersonaContacto
    { 
        public int Id { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public Grupo? Grupo { get; set; }
        public int? GrupoId { get; set; }
        public Semestre Semestre { get; set; }
        public int SemestreId { get; set; }
        public List<AlumnoContacto> Contactos { get; set; }
        public int IdEstado { get; set; }
        public AlumnoEstado Estado { get; set; }
        public List<CalificacionEvaluacion> CalificacionEvaluaciones {get; set; }
        public string Name { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public string NumeroTelefonico { get; set; }
        public string Mail { get; set; }
        public int Sexo { get; set; }
    }

}

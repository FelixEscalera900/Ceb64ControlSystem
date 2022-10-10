using CEB64ControlSystem.AbstractModels;

namespace CEB64ControlSystem.Models
{
    public class AlumnoContacto : PersonaContacto
    {
        public int Id { get; set; }
        public string Relacion { get; set; }
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
    }
}

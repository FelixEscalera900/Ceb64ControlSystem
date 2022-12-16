using CEB64ControlSystem.AbstractModels;

namespace CEB64ControlSystem.Models
{
    public class AlumnoContacto : PersonaContacto
    {
        public int Id { get; set; }
        public string Relacion { get; set; }
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
        public string Name { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public string NumeroTelefonico { get; set; }
        public string Mail { get; set; }
    }
}

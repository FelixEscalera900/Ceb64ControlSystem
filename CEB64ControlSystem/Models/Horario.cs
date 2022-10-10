namespace CEB64ControlSystem.Models
{
    public class Horario
    {
        public int Id { get; set; }
        public int HoraClaseID { get; set; }
        public HoraClase HoraClase { get; set; }
        public int DiaClaseId { get; set; }
        public DiaClase DiaClase { get; set; }
        public int AsignaturaID { get; set; }
        public Asignatura Asignatura { get; set; }

    }
}

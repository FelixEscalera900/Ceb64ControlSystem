using CEB64ControlSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CEB64ControlSystem.ModelsDto
{
    public class AlumnoContactoDto
    {
        public int Id { get; set; }
        [Display(Name = "Relación")]
        public string Relacion { get; set; }
        public int AlumnoId { get; set; }
        public AlumnoDto Alumno { get; set; }
        public string Name { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Display(Name = "Número telefónico")]
        public string NumeroTelefonico { get; set; }
        [Display(Name = "Correo")]
        public string Mail { get; set; }
        [Display(Name = "Nombre")]
        public string FullName { get; set; }
    }
}

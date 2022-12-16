using CEB64ControlSystem.AbstractModels;
using CEB64ControlSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.ModelsDto
{
    public class AlumnoDto : PersonaContacto, KeyedDto
    {
        [Display(Name = "Matrícula")]
        public int Id { get; set; }
        [Display(Name = "Fecha Ingreso")]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Fecha de ingreso")]
        public DateTime FechaIngreso { get; set; }
        [Display(Name = "Fecha Egreso")]
        public DateTime? FechaEgreso { get; set; }
        public GrupoDto? Grupo { get; set; }
        public int GrupoId { get; set; }
        public Semestre Semestre { get; set; }
        public int SemestreId { get; set; }
        [Display(Name = "Contactos")]
        public List<AlumnoContactoDto> Contactos { get; set; }
        public int? IdEstado { get; set; }
        public AlumnoEstado Estado { get; set; }
        public List<CalificacionEvaluacion> CalificacionEvaluaciones { get; set; }
        [Display(Name = "Nombre Completo")]
        public string FullName { get; set; }
        [Display(Name = "N.L.")]
        public string NumeroDeLista { get; set; }
        public string Name { get ; set ; }
        public string ApellidoPaterno { get ; set ; }
        public string ApellidoMaterno { get ; set ; }
        public string Direccion { get ; set ; }
        public string NumeroTelefonico { get ; set ; }
        public string Mail { get ; set ; }
        public int Sexo { get; set; }
    }
}

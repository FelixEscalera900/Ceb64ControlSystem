using CEB64ControlSystem.AbstractModels;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CEB64ControlSystem.ViewModels.Alumnos
{
    public class EditAlumnoViewModel : KeyedDto, PersonaContacto
    {
        public SelectList? SemestresSelect { get; set; }
        public SelectList? GruposSelect { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ApellidoPaterno { get; set; }
        [Required]
        public string ApellidoMaterno { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string NumeroTelefonico { get; set; }
        [Required]
        public string Mail { get; set; }
        [Display(Name = "Matrícula")]
        [Required]
        public int Id { get; set; }
        [Display(Name = "Fecha Ingreso")]
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Fecha de ingreso")]
        [Required]
        public DateTime FechaIngreso { get; set; }
        [Display(Name = "Fecha Egreso")]
        [Required]
        public DateTime? FechaEgreso { get; set; }
        [Required]
        [Display(Name = "Grupo")]
        public int GrupoId { get; set; }
        [Required]
        [Display(Name = "Semestre")]
        public int SemestreId { get; set; }
    }
}

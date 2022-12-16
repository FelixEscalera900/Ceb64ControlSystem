using CEB64ControlSystem.AbstractModels;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.ViewModels.Alumnos
{
    public class CreateAlumnoViewModel : KeyedDto, PersonaContacto
    {
        public CreateAlumnoViewModel()
        {
            Semestres = new List<Semestre>();
        }
        public List<Semestre>? Semestres { get; set; }
        public string Name { get; set; }
        [Required]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }
        [Required]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }
        [Required]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Required]
        [Display(Name = "Numero telefónico")]
        public string NumeroTelefonico { get; set; }
        [Required]
        [Display(Name = "Correo electrónico")]
        public string Mail { get; set; }

        [Display(Name = "Matrícula")]
        public int Id { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        public DateTime? FechaNacimiento { get; set; }
        [Display(Name = "Fecha de ingreso")]
        public DateTime? FechaIngreso { get; set; }
        [Display(Name = "Fecha Egreso")]
        public DateTime? FechaEgreso { get; set; }
        [Display(Name = "Grupo")]
        public int GrupoId { get; set; }
        [Display(Name = "Semestre")]
        public int SemestreId { get; set; }
    }

}

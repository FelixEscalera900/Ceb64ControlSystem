using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.ViewModels.Grupos
{
    public class EditGrupoViewModel : KeyedDto
    {
        public List<Semestre>? Semestres { get; set; }

        [Required]
        public int Id { get; set; }

        [Display(Name = "Grupo")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Semestre")]
        [Required]
        public int SemestreID { get; set; }
    }
}


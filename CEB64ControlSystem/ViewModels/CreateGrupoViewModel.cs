using CEB64ControlSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.ViewModels
{
    public class CreateGrupoViewModel : Grupo
    {
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Semestre")]
        public int SemestreId { get; set; }
        public SelectList? SemestresSelect { get; set; }
    }
    
}

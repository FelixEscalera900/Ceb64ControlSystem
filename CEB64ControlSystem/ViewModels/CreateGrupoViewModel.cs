using CEB64ControlSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CEB64ControlSystem.ViewModels
{
    public class CreateGrupoViewModel : Grupo
    {
        public SelectList? SemestresSelect { get; set; }
    }
    
}

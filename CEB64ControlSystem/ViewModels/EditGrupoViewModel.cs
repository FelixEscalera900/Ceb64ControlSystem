using CEB64ControlSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CEB64ControlSystem.ViewModels
{
    public class EditGrupoViewModel : Grupo
    {
        public List<Semestre> Semestres { get; set; }

    }
}


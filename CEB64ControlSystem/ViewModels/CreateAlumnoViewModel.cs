using CEB64ControlSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CEB64ControlSystem.ViewModels
{
    public class CreateAlumnoViewModel : Alumno
    {
        public SelectList? SemestresSelect { get; set; }

        public SelectList? GruposSelect { get; set; }

    }
    
}

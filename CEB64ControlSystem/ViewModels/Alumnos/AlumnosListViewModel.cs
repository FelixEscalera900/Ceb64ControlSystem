using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.ViewModelFactories;

namespace CEB64ControlSystem.ViewModels.Alumnos
{
    public class AlumnosListViewModel : FilteredIdentityListViewModel<AlumnoDto>
    {
        public AlumnosListViewModel()
        {
            Semestres = new List<Semestre>();
            Grupos = new List<GrupoDto>();
            PluralName = "Alumnos";
            Filters = new AlumnoDto();
            CreationRoute = "/Alumnos/Create";
            SingularName = "Alumno";
        }


        public List<Semestre> Semestres { get; set; }
        public List<GrupoDto> Grupos { get; set; }
    }
}

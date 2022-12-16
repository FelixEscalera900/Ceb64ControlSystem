using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.ViewModelFactories;

namespace CEB64ControlSystem.ViewModels.Grupos
{
    public class GruposListViewModel : FilteredIdentityListViewModel<GrupoDto>

    {
        public GruposListViewModel()
        {
            Semestres = new List<Semestre>();
            PluralName = "Grupos";
            SingularName = "Grupo";
            Filters = new GrupoDto();
            CreationRoute = "/Grupoes/Create";

        }

        public List<Semestre> Semestres { get; set; }
    }
}

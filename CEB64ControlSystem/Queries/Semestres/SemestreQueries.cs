using AutoMapper;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.Queries.Periodos;

namespace CEB64ControlSystem.Queries.Semestres
{
    public class SemestreQueries : Query<Semestre>, ISemestreQueries
    {
        IPeriodoQueries _PeridoQueries;
        public SemestreQueries(ApplicationDbContext context, IMapper mapper, IPeriodoQueries PeridoQueries) : base(context, mapper)
        {
            _PeridoQueries = PeridoQueries;
        }

        public List<Semestre> GetPeriodoSemestres()
        {
            Periodo CurrentPeriodo = _PeridoQueries.GetCurrentPeriodo();

            List<Semestre> semestres = CurrentPeriodo.PeriodoTipo.Semestres;

            foreach (Semestre semest in semestres)
            {
                semest.PeriodoTipo = null;
                semest.Grupos = null;
            }

            return semestres;

        }


    }
}

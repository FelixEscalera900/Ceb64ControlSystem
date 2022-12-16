using AutoMapper;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CEB64ControlSystem.Queries.Periodos
{
    public class PeriodoQueries : Query<Periodo>, IPeriodoQueries
    {
        public PeriodoQueries(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public Periodo GetCurrentPeriodo()
        {
            return _context.Periodos.Include(p => p.PeriodoTipo).ThenInclude(p => p.Semestres).FirstOrDefault(p => p.IsTheCurrentPeriodo);
        }
    }
}

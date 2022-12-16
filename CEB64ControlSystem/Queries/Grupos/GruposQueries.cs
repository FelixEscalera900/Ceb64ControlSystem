using AutoMapper;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.Models;
using CEB64ControlSystem.ModelsDto;
using CEB64ControlSystem.ModelsDto.Common;
using CEB64ControlSystem.Queries.Periodos;
using CEB64ControlSystem.Queries.Semestres;
using CEB64ControlSystem.ViewModels.Grupos;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CEB64ControlSystem.Queries.Grupos
{
    public class GruposQueries : Query<Grupo>, IGruposQueries
    {
        IPeriodoQueries _PeriodoQueries;
        ISemestreQueries _semestreQueries;

        public GruposQueries(ApplicationDbContext context, IMapper mapper, IPeriodoQueries periodoQueries, ISemestreQueries semestreQueries) : base(context, mapper)
        {
            _PeriodoQueries = periodoQueries;
            _semestreQueries = semestreQueries;
        }

        public List<GrupoDto> FindMany()
        {

            return FindMany(new GrupoDto());
        }

        public List<GrupoDto> FindMany(GrupoDto Filters)
        {

            var CurrentPeriodo = _PeriodoQueries.GetCurrentPeriodo();

            List<Grupo> grupos = _context.Grupos
                .Where(g =>
                    g.PeriodoId == CurrentPeriodo.PeriodoId &&
                    (Filters.Name == null || g.Name.Contains(Filters.Name)) &&
                    (Filters.SemestreID == 0 || g.SemestreID == Filters.SemestreID)
                )
                .Include(g => g.Periodo)
                .Include(g => g.PlanEstudio)
                .Include(g => g.Semestre)
                .Include(g => g.Alumnos)
                .ToList();

            return _mapper.Map<List<GrupoDto>>(grupos);
        }

        public GrupoDto Find(int id)
        {

            var grupo = _context.Grupos
                .Include(g => g.PlanEstudio)
                .Include(g => g.Semestre)
                .Include(a => a.Alumnos)
                .Include(g => g.Asignaturas)
                .FirstOrDefault(g => id == g.Id);

            return _mapper.Map<GrupoDto>(grupo);
        }

        public EntityBasedModel GetEntityBasedModel<EntityBasedModel>(int Id) where EntityBasedModel : new()
        {
            Grupo grupo = _context.Grupos.Find(Id);
            EntityBasedModel model = _mapper.Map<EntityBasedModel>(grupo);

            return model;
        }

        public List<SelectOption> GetSelectList(GrupoDto Filters)
        {
            return FindMany(Filters)
                .Select(a => 
                new SelectOption() { Id = a.Id, Name = a.Name})
                .ToList();
        }
    }
}
